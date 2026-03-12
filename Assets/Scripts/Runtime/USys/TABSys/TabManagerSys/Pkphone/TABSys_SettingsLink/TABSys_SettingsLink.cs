using UnityEngine;
using Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_SettingsLink.Modules;

namespace Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_SettingsLink
{
    public class TABSys_SettingsLinker: MonoBehaviour
    {
        private TABSys_SettingsLINK TABSys_SettingsLinkI;
        public void TABSys_settingsLink() 
        {
            TABSys_SettingsLinkI.TABSys_SettingsMenuI();
        }
    }
}