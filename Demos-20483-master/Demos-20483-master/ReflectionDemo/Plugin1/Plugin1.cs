using ReflectionDemo;

namespace Plugin1
{
    public class Plugin1 : IPlugin
    {
	    public string Nome
	    {
		    get { return "Plugin 1"; }
		    
	    }

	    public string Mensagem()
	    {
		    return "Mensagem 1";
	    }
    }
}
