using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
namespace ModuleA
{
    public class ModuleCModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentInner", typeof(ViewC));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
           
        }
    }
}
