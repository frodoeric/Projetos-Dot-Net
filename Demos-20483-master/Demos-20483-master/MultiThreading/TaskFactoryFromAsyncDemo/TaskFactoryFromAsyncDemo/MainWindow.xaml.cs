using System.Net;
using System.Threading.Tasks;
using System.Windows;

namespace TaskFactoryFromAsyncDemo
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

		private async void IrButton_Click(object sender, RoutedEventArgs e)
		{
			var request = (HttpWebRequest)WebRequest.Create(EnderecoTextBox.Text);

			var response = await Task<WebResponse>
							.Factory
							.FromAsync(request.BeginGetResponse,
							request.EndGetResponse,
							 request) as HttpWebResponse;


			StatusLabel.Content = response.StatusDescription;
		}
	}
}
