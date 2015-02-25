using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ReflectionDemo
{
	public partial class Form1 : Form
	{
		private List<IPlugin> _plugins = new List<IPlugin>();
		DirectoryInfo _dir = new DirectoryInfo(Application.StartupPath);

		public Form1()
		{
			InitializeComponent();
		}

		private void CarregarButton_Click(object sender, EventArgs e)
		{
			foreach (FileInfo file in _dir.GetFiles("*.dll"))
			{
				Assembly assembly = Assembly.LoadFrom(file.FullName);
				foreach (Type type in assembly.GetTypes())
				{
					if (typeof(IPlugin).IsAssignableFrom(type) && type.IsAbstract == false)
					{
						var plugin = Activator.CreateInstance(type) as IPlugin;
						_plugins.Add(plugin);
					}
				}
			}
		}

		private void ExecutarButton_Click(object sender, EventArgs e)
		{
			MensagemLabel.Text = "";
			foreach (var plugin in _plugins)
			{
				MensagemLabel.Text +=
					String.Format("Mensagem do plugin {0}: {1}\n", plugin.Nome, plugin.Mensagem());
			}
		}
	}
}
