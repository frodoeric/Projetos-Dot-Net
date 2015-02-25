using ConsoleApplication1;
using Ninject.Modules;

namespace Dependency2
{
    public class StartUp : NinjectModule
    {
        public override void Load()
        {
            Bind<IFalante>().To<Cachorro>();
        }
    }
}