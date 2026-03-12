using Project_Pkdsim.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC;
using Project_Pkdsim.USys.UTPSys.UHousesTeleporterSys.HOUSES.PLAYER;
using UnityEngine;

namespace Project_Pkdsim.USys.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_WayPointLink.Modules.Menu_I.Houses
{
	public class TabSys_WaypointMenuHouses : MonoBehaviour 
	{
		private UHTPSys_NPC_FamilyTeleporter UHTPSys_NPC_FamilyTeleporter;
        private UHTPSys_Player_FamilyTeleporter UHTPSys_Player_FamilyTeleporter;

		private bool PlayerHouseMenu;
		private bool NPCHousesMenu;

		public void DisplayMenu() 
        {
            DisplayNPCHouses();
            DisplayPlayerHouse();
        }
        private void DisplayNPCHouses() 
        {
			UnityEngine.Assertions.Assert.IsFalse(PlayerHouseMenu);
			UHTPSys_NPC_FamilyTeleporter.UHTPSys_NPC_FamilySceneTeleporter("family");
        }
        private void DisplayPlayerHouse() 
        {
			UnityEngine.Assertions.Assert.IsFalse(NPCHousesMenu);
            UHTPSys_Player_FamilyTeleporter.UHTPSys_Player_FamilySceneTeleporter();
        }
	}
}