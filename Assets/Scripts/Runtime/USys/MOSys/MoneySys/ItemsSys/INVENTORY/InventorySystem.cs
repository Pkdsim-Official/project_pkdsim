using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.INVENTORY 
{
	public class InventorySystem : ITEMSDatabaseSys
	{
		public void Get_Inventory() 
		{
			Get_Items("", "", "");
		}
	}
}