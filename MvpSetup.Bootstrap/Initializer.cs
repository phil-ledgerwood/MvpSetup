using System.Web;
using MvpSetup.Core.Framework;

namespace MvpSetup.Bootstrap
{
    public class Initializer : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            var bootStrapper = new Bootstrapper();
            bootStrapper.BootstrapStructureMap();
            Ioc.Container = bootStrapper.Container;
        }

        public void Dispose() { }
    }
}
