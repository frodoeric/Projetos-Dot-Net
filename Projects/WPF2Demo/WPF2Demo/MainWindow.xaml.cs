using System;
using System.Collections.Generic;
using System.Linq;
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
using WPF2Demo.Model;

namespace WPF2Demo
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var lista = new List<Cliente>
            {
                new Cliente{Nome = "Fulano", Sobrenome = "Silva"},
                new Cliente{Nome = "Manoel", Sobrenome = "Silva"},
                new Cliente{Nome = "Joaquim", Sobrenome = "Silva"},
            };

            ListaDeClientes.ItemsSource = lista;
        }
    }
}
