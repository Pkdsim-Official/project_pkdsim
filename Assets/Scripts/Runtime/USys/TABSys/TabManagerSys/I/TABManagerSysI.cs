using Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS;
using Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_UILinker;

namespace Project_Pkdsim.USys.TabManagerSys.Modules
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