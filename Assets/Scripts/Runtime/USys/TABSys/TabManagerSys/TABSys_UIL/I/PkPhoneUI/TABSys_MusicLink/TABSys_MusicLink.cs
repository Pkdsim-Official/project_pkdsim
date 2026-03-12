using Project_Pkdsim.USys.TabManagerSys.Modules.UILoader.Modules.PkPhoneUI.PkPhoneAPPS.TABSys_BaseLink;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Project_Pkdsim.USys.TabManagerSys.Modules.UILoader.Modules.PkPhoneUI.PkPhoneAPPS.TABSys_MusicLink
{
    public class TABSys_MusicPanelLinker : TABSys_BaseLinker
    {
        private GameObject PkPhone_MusicPanel;
		private Button PkPhone_Music;

        private void OpenMusicPanel()
        {
            SetAllPanelsInactive();
            PkPhone_MusicPanel.SetActive(true);

            // if set active gives true load "PkPhone_MusicMenu"
            if (PkPhone_MusicPanel.activeSelf == true)
            {
                SceneManager.LoadScene("PkPhone_MusicMenu");
            }
		}

		private void PkPhone_Music_Panel_Listener()
		{
			PkPhone_Music.onClick.AddListener(OpenMusicPanel);
		}
		public void TABSys_MusicMenuI()
        {
            PkPhone_Music_Panel_Listener();
            OpenMusicPanel();
        }
    }
}