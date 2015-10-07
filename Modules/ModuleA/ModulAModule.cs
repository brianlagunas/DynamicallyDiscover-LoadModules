using Prism.Modularity;
using Prism.Regions;

namespace ModuleA
{
    public class ModulAModule : IModule
    {
        private readonly IRegionManager _manager;

        public ModulAModule(IRegionManager manager)
        {
            _manager = manager;
        }

        public void Initialize()
        {
            _manager.RegisterViewWithRegion("ContentRegion", typeof (ModuleAView));
        }
    }
}
