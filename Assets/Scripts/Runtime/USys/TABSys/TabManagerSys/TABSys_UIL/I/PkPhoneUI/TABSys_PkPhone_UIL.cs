using Project_Pkdsim.USys.TabManagerSys.Modules.UILoader.Modules.PkPhoneUI.PkPhoneAPPS.TABSys_AffectionLink;
using Project_Pkdsim.USys.TabManagerSys.Modules.UILoader.Modules.PkPhoneUI.PkPhoneAPPS.TABSys_HomeLink;
using Project_Pkdsim.USys.TabManagerSys.Modules.UILoader.Modules.PkPhoneUI.PkPhoneAPPS.TABSys_MusicLink;
using Project_Pkdsim.USys.TabManagerSys.Modules.UILoader.Modules.PkPhoneUI.PkPhoneAPPS.TABSys_PkpediaLink;
using Project_Pkdsim.USys.TabManagerSys.Modules.UILoader.Modules.PkPhoneUI.PkPhoneAPPS.TABSys_SettingsLink;
using Project_Pkdsim.USys.TabManagerSys.Modules.UILoader.Modules.PkPhoneUI.PkPhoneAPPS.TABSys_SocialMediaLink;
using Project_Pkdsim.USys.TabManagerSys.Modules.UILoader.Modules.PkPhoneUI.PkPhoneAPPS.TABSys_StoreLink;
using Project_Pkdsim.USys.TabManagerSys.Modules.UILoader.Modules.PkPhoneUI.PkPhoneAPPS.TABSys_WayPointLink;
using UnityEngine;

namespace Project_Pkdsim.USys.TabManagerSys.TABSys_UIL.Modules.PkPhone
{
    // PkPhone UI Listener 
    public class TABSys_PkphoneUIL : MonoBehaviour
    {
        private TABSys_WaypointPanelLinker TABSys_WaypointPanelLinker;
        private TABSys_MusicPanelLinker TABSys_MusicPanelLinker;
        private TABSys_PkpediaPanelLinker TABSys_PkpediaPanelLinker;
        private TABSys_SettingsPanelLinker TABSys_SettingsPanelLinker;
        private TABSys_StorePanelLinker TABSys_StorePanelLinker;
        private TABSys_SocialMediaPanelLinker TABSys_SocialMediaPanelLinker;
        private TABSys_AffectionPanelLinker TABSys_AffectionPanelLinker;
        private TABSys_HomePagePanelLinker TABSys_HomePagePanelLinker;

        public void TABSys_AffectionPanelLink()
        {
            TABSys_AffectionPanelLinker.TABSys_AffectionMenuI();
        }
        public void TABSys_HomePagePanelLink()
        {
            TABSys_HomePagePanelLinker.TABSys_HomePageMenuI();
        }
        public void TABSys_SettingsPanelLink()
        {
            TABSys_SettingsPanelLinker.TABSys_SettingsMenuI();
        }
        public void TABSys_StorePanelLink()
        {
            TABSys_StorePanelLinker.TABSys_StoreMenuI();
        }
        public void TABSys_SocialMediaPanelLink()
        {
            TABSys_SocialMediaPanelLinker.TABSys_SocialMediaMenuI();
        }
        public void TABSys_MusicPanelLink()
        {
            TABSys_MusicPanelLinker.TABSys_MusicMenuI();
        }
        public void TABSys_PkpediaPanelLink()
        {
            TABSys_PkpediaPanelLinker.TABSys_PkpediaMenuI();
        }
        public void TABSys_WaypointPanelLink()
        {
            TABSys_WaypointPanelLinker.TABSys_WaypointMenuI();
        }
        public void PkPhone_Panels()
        {
            TABSys_WaypointPanelLinker.TABSys_WaypointMenuI();
            TABSys_MusicPanelLinker.TABSys_MusicMenuI();
            TABSys_PkpediaPanelLinker.TABSys_PkpediaMenuI();
            TABSys_SettingsPanelLinker.TABSys_SettingsMenuI();
            TABSys_StorePanelLinker.TABSys_StoreMenuI();
            TABSys_SocialMediaPanelLinker.TABSys_SocialMediaMenuI();
            TABSys_AffectionPanelLinker.TABSys_AffectionMenuI();
            TABSys_HomePagePanelLinker.TABSys_HomePageMenuI();
        }
        public void PkPhone_Panels_Listener()
        {
            TABSys_WaypointPanelLinker = new TABSys_WaypointPanelLinker();
            TABSys_MusicPanelLinker = new TABSys_MusicPanelLinker();
            TABSys_PkpediaPanelLinker = new TABSys_PkpediaPanelLinker();
            TABSys_SettingsPanelLinker = new TABSys_SettingsPanelLinker();
            TABSys_StorePanelLinker = new TABSys_StorePanelLinker();
            TABSys_SocialMediaPanelLinker = new TABSys_SocialMediaPanelLinker();
            TABSys_AffectionPanelLinker = new TABSys_AffectionPanelLinker();
            TABSys_HomePagePanelLinker = new TABSys_HomePagePanelLinker();
        }
        public void TABSys_PkPhoneAppsI()
        {
            PkPhone_Panels_Listener();
            PkPhone_Panels();
        }

    }
}
