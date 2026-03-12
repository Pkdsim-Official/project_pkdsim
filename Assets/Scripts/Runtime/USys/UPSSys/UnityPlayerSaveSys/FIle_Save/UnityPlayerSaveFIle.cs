using Project_Pkdsim.USys.LoveSys.Modules.LoveScripts.Modules.NPC;
using Project_Pkdsim.USys.MoneySys.UnityItemSys.INVENTORY;

namespace Project_Pkdsim.USys.UnityPlayerSaveSys.FileSave
{
	public class UnityPlayerSaveFIle
	{
		private InventorySystem  inventory;

		private NPC_LOVESys NPC_LoveSys;

		public int Build_Version;

		public UnityEngine.Object pkphone;

		public void PlayerDataBuilder(string value)
		{
			Build_Version = 1;
			NPC_LoveSys.NPC_LoveSys();         // Call the method        // Initialize inventory
			inventory.Get_Inventory();         // Call the method
		}
		public void PlayerDataBuild() 
		{
			PlayerDataBuilder("value");
		}
	}
}

