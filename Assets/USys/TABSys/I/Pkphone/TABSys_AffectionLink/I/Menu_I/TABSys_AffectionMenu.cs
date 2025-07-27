using project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I.AffectionStats;
using UnityEngine;

namespace project_pkdsim.Assets.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_AffectionLink.I.Menu_I
{
	public class TABSys_AffectionMenu : MonoBehaviour
	{
		private TABSys_AffectionStatsMenu TabSys_AffectionStatsMenu;
        public void DisplayMenu() 
        {
            AffectionMenuI();
        }
        private void  AffectionMenuI() 
        {
            TabSys_AffectionStatsMenu.DisplayMenu();
        }
	}
}