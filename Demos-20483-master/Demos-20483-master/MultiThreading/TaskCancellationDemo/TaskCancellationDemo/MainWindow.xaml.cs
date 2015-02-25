using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace TaskCancellationDemo
{
	public partial class MainWindow : Window
	{
		private CancellationTokenSource _source;
		public MainWindow()
		{
			InitializeComponent();
		}

		private void StartButton_Click(object sender, RoutedEventArgs e)
		{
			_source = new CancellationTokenSource();
			Task.Run(() => DoWork(_source.Token), _source.Token);
		}

		private void DoWork(CancellationToken token)
		{
			for (int i = 1; i < 101; i++)
			{
				Thread.Sleep(100);
				Dispatcher.Invoke(() => progressBar.Value = i);
				if (token.IsCancellationRequested)
				{
					Dispatcher.Invoke(() => progressBar.Value = 0);
					token.ThrowIfCancellationRequested();
				}
			}
		}

		private void CancelButton_Click(object sender, RoutedEventArgs e)
		{
			_source.Cancel();
		}

		private void StartSemTaskButton_Click(object sender, RoutedEventArgs e)
		{
			for (int i = 1; i < 101; i++)
			{
				Thread.Sleep(100);
				progressBar.Value = i;
			}
		}
	}
}
