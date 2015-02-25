using System.Windows;
using CadastroDeClientes.Model;
using CadastroDeClientes.WPF.ClientesServiceReference;

namespace CadastroDeClientes.WPF
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			
		}

		private void Carregar_Click(object sender, RoutedEventArgs e)
		{
			var serviceClient = new ClientesServiceClient();
			var clientes = serviceClient.GetClientes();
			
			ListaDeClientes.ItemsSource = clientes;
		}

		private void Salvar_Click(object sender, RoutedEventArgs e)
		{
			var novoCliente = new Cliente
			{
				Nome = NomeTextBox.Text,
				Sobrenome = SobrenomeTextBox.Text
			};

			var serviceCliente = new ClientesServiceClient();
			serviceCliente.AddCliente(novoCliente);
		}
	}
}
