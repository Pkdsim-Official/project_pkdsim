using Project_Pkdsim.USys.TabManagerSys.Modules.UILoader.Modules.PkPhoneUI.PkPhoneAPPS.TABSys_BaseLink;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Project_Pkdsim.USys.TabManagerSys.Modules.UILoader.Modules.PkPhoneUI.PkPhoneAPPS.TABSys_PkpediaLink
{
    public class TABSys_PkpediaPanelLinker : TABSys_BaseLinker
    {
        private GameObject PkPhone_PkpediaPanel;
		private Button PkPhone_Pkpedia;

        private void OpenPkpediaPanel()
        {
            SetAllPanelsInactive();
            PkPhone_PkpediaPanel.SetActive(true);

            // if set active gives true load "Pkpedia"
            if (PkPhone_PkpediaPanel.activeSelf == true)
            {
                SceneManager.LoadScene("PkPhone_PkpediaMenu");
            }
		}

		private void PkPhone_Pkpedia_Panel_Listeners()
		{
			PkPhone_Pkpedia.onClick.AddListener(OpenPkpediaPanel);
		}
		public void TABSys_PkpediaMenuI()
        {
            PkPhone_Pkpedia_Panel_Listeners();
            OpenPkpediaPanel();
        }
    }
}