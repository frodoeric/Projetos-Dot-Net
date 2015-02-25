using CadastroDeClientes.Client.ServiceReference1;
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

namespace CadastroDeClientes.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AcessoADados dados;

        public MainWindow()
        {
            InitializeComponent();
            dados = new AcessoADados();
        }

        private void SalvarButton_Click(object sender, RoutedEventArgs e)
        {


            var novoCliente = new Cliente
            {
                Nome = NomeText.Text,
                Sobrenome = SobrenomeText.Text
            };
            dados.AdicionarCliente(novoCliente);
            

        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BarraProgresso.Visibility = Visibility.Visible;
            await Task.Run(() =>
                {
                    var clientes = dados.ObterClientes();
                    Dispatcher.Invoke(() =>
                        {
                            ClientesListBox.ItemsSource = dados.ObterClientes();
                            BarraProgresso.Visibility = Visibility.Collapsed;
                        });
                });

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var clienteSelecionado = ClientesListBox.SelectedItem as Cliente;
            if (clienteSelecionado != null)
            {
                dados.ExcluirCliente(clienteSelecionado);
                
            }
        }

        private void ClientesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

                var clienteSelecionado = ClientesListBox.SelectedItem as Cliente;
            if (clienteSelecionado != null)
            {
                NomeText.Text = clienteSelecionado.Nome;
                SobrenomeText.Text = clienteSelecionado.Sobrenome;
            }
            
        }

        private void AtualizarButton_Click(object sender, RoutedEventArgs e)
        {
            var clienteSelecionado = ClientesListBox.SelectedItem as Cliente;
            clienteSelecionado.Sobrenome = SobrenomeText.Text;
            clienteSelecionado.Nome = NomeText.Text;
            dados.AtualizarCliente(clienteSelecionado);
        }


    }
}
