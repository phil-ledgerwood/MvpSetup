using MvpSetup.Core.Presenters;
using StructureMap.Configuration.DSL;

namespace MvpSetup.Bootstrap.Registries
{
    public class CoreRegistry : Registry
    {
        public CoreRegistry()
        {
            Scan(scanner =>
            {
                scanner.RegisterConcreteTypesAgainstTheFirstInterface();
                scanner.AssemblyContainingType<PresenterBase>();
                scanner.WithDefaultConventions();
                scanner.SingleImplementationsOfInterface();
            });
        }
    }
}
