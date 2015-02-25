using ReflectionDemo;

namespace Plugin2
{
	public class Plugin2 : IPlugin
	 {
		public string Nome
		{
			get { return "Plugin 2"; }
		}

		public string Mensagem()
		{
			return "Mensagem 2";
		}
	 }
}
