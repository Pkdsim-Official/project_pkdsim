using Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_WayPointLink.Modules.Menu_I;
using UnityEngine;

namespace Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_WayPointLink.Modules
{
	public class TABSys_WayPointLINK : MonoBehaviour 
	{
		private TabSys_WaypointMenu TABSys_WayPointMenu;
		public void TABSys_WaypointMenuI() 
		{
			TABSys_WayPointMenu.DisplayMenu();
		}
	}
}