using UnityEngine;
using UnityEngine.UI;

namespace project_pkdsim.Assets.USys.TabManagerSys.TABSys_UIL.I.PkPhone
{
    // PkPhone UI Listener 
    public class TABSys_PkphoneUIL : MonoBehaviour
    {
        public GameObject PkPhone_HomePagePanel;
        public GameObject PkPhone_PkpediaPanel;
        public GameObject PkPhone_SettingsPanel;
        public GameObject PkPhone_WaypointPanel;
        public GameObject PkPhone_StorePanel;
        public GameObject PkPhone_SocialMediaPanel;
        public GameObject PkPhone_MusicPanel;
        public GameObject PkPhone_AffectionPanel;

        public Button PkPhone_HomePage;
        public Button PkPhone_Pkpedia;
        public Button PkPhone_Settings;
        public Button PkPhone_Waypoint;
        public Button PkPhone_Store;
        public Button PkPhone_SocialMedia;
        public Button PkPhone_Music;
        public Button PkPhone_Affection;

        private void Start()
        {
            PkPhone_Panel_Listeners();
            OpenHomePagePanel(); // Ensures homepage is active on start
        }

        private void OpenHomePagePanel()
        {
            SetAllPanelsInactive();
            PkPhone_HomePagePanel.SetActive(true);
        }

        private void OpenPkpediaPanel()
        {
            SetAllPanelsInactive();
            PkPhone_PkpediaPanel.SetActive(true);
        }

        private void OpenSettingPanel()
        {
            SetAllPanelsInactive();
            PkPhone_SettingsPanel.SetActive(true);
        }

        private void OpenWaypointPanel() 
        {
            SetAllPanelsInactive();
            PkPhone_WaypointPanel.SetActive(true);
        }

        private void OpenStorePanel() 
        {
            SetAllPanelsInactive();
            PkPhone_StorePanel.SetActive(true);
        }
        private void OpenSocialMediaPanel() 
        {
            SetAllPanelsInactive();
            PkPhone_SocialMediaPanel.SetActive(true);
        }
        private void OpenMusicPanel() 
        {
            SetAllPanelsInactive();
            PkPhone_MusicPanel.SetActive(true);
        }
        private void OpenAffectionPanel() 
        {
            SetAllPanelsInactive();
            PkPhone_AffectionPanel.SetActive(true);
        }

        private void SetAllPanelsInactive()
        {
            PkPhone_HomePagePanel.SetActive(false);
            PkPhone_PkpediaPanel.SetActive(false);
            PkPhone_SettingsPanel.SetActive(false);
            PkPhone_WaypointPanel.SetActive(false);
            PkPhone_StorePanel.SetActive(false);
            PkPhone_SocialMediaPanel.SetActive(false);
            PkPhone_MusicPanel.SetActive(false);
            PkPhone_AffectionPanel.SetActive(false);
        }

        private void PkPhone_Panel_Listeners()
        {
            PkPhone_HomePage.onClick.AddListener(OpenHomePagePanel);
            PkPhone_Pkpedia.onClick.AddListener(OpenPkpediaPanel);
            PkPhone_Settings.onClick.AddListener(OpenSettingPanel);
            PkPhone_Waypoint.onClick.AddListener(OpenWaypointPanel);
            PkPhone_Store.onClick.AddListener(OpenStorePanel);
            PkPhone_SocialMedia.onClick.AddListener(OpenSocialMediaPanel);
            PkPhone_Music.onClick.AddListener(OpenMusicPanel);
            PkPhone_Affection.onClick.AddListener(OpenAffectionPanel);
        }
        public void PkPhone_Panels() 
        {
            PkPhone_Panel_Listeners();
        }
    }
}
