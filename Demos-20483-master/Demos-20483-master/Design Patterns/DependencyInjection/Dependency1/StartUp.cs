using ConsoleApplication1;
using Ninject.Modules;

namespace Dependency1
{
    public class StartUp : NinjectModule
    {
        public override void Load()
        {
            Bind<IFalante>().To<Gato>();
        }
    }
}