using project_pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS;
using project_pkdsim.USys.TabManagerSys.Pkphone.TABSys_UILinker;

namespace project_pkdsim.USys.TabManagerSys.Modules
{
    public class UnityTabManagerSysI
    {
        private TABSys_PkPhoneApps TABSys_PkPhoneApps;
        private TABSys_UILink TABSys_PkPhoneAppsPanels;
        public void TABSys_PkPhoneAppsI()
        {
            TABSys_PkPhoneApps.TabSys_PkPhoneApps();
        }
        public void TABSys_PkPhoneAppsPanel()
        {
            TABSys_PkPhoneAppsPanels.TABSys_UI();
        }
    }
}