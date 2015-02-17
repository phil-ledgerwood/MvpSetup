using StructureMap;
using StructureMap.Pipeline;

namespace MvpSetup.Core.Framework
{
    public class Ioc
    {
        public static IContainer Container;

        public static void Reset()
        {
            if (Container == null) return;

            Container.Dispose();
            Container = null;
        }

        public static TPresenterType GetPresenter<TPresenterType>(object view)
        {
            var explicitArguments = new ExplicitArguments();
            foreach (var implementedInterface in view.GetType().GetInterfaces())
                explicitArguments.Set(implementedInterface, view);

            return Container.GetInstance<TPresenterType>(explicitArguments);
        }
    }
}
