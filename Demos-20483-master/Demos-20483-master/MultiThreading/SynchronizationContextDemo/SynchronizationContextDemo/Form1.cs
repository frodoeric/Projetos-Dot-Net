using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SynchronizationContextDemo
{
	public partial class Form1 : Form
	{
		private readonly TaskScheduler _syncContextTaskScheduler;
		public Form1()
		{
			InitializeComponent();
			_syncContextTaskScheduler = TaskScheduler.FromCurrentSynchronizationContext();
			Text = "Synchronization Context Task Scheduler Demo";
			Visible = true; Width = 600; Height = 100;
		}

		private CancellationTokenSource _cts;
		protected override void OnMouseClick(MouseEventArgs e)
		{
			button1_Click(this,e);
			base.OnMouseClick(e);
		}

		private int Sum(CancellationToken token, int n)
		{
			int sum = 0;
			for (int j = 0; j < n; j++)
			{
				sum += j;
				if (token.IsCancellationRequested)
				{
					token.ThrowIfCancellationRequested();
				}
				Thread.Sleep(1);
			}
			return sum;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (_cts != null)
			{
				// Cancele a operação que está em andamento
				_cts.Cancel();
				_cts = null;
			}
			else
			{
				// Nenhuma operação está em andamento, então inicie uma
				Text = "Operação em andamento";
				_cts = new CancellationTokenSource();

				// Esta task usa o task scheduler padrão e executa em um thread do thread pool
				Task<Int32> t = Task.Run(() => Sum(_cts.Token, 200), _cts.Token);

				// Estas tasks usam o task scheduler do SynchronizationContext e executam na thread da GUI
				t.ContinueWith(task => Text = "Resultado: " + task.Result,
					CancellationToken.None, TaskContinuationOptions.OnlyOnRanToCompletion,
					_syncContextTaskScheduler);

				t.ContinueWith(task => Text = "Operação cancelada",
					CancellationToken.None, TaskContinuationOptions.OnlyOnCanceled,
					_syncContextTaskScheduler);

				t.ContinueWith(task => Text = "Operação gerou uma exceção",
					CancellationToken.None, TaskContinuationOptions.OnlyOnFaulted,
					_syncContextTaskScheduler);
			}
		}
	}
}
