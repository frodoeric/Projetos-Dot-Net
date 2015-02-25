using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AsncDemo2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //GetStringAsync cria uma thread
            var cliente = new HttpClient();
            string result = await cliente.GetStringAsync("http://www.pazotto.com");//recebe uma task de string
            //o método tem que ser async para poder utilizar o await.
            //await não irá bloquear a tarefa
            destino.Text = result;
            
        }

        private async Task<string> BaixarSiteAsync()//para saber o tempo do resultado, o método com o nome Async no final precisa retornar Task
        {
            var cliente = new HttpClient();
            var result = await cliente.GetStringAsync("http://www.pazotto.com");
            return result;
        }
    }
}
