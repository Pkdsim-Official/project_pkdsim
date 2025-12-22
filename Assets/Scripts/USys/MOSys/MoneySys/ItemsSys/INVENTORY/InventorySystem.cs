using project_pkdsim.USys.MoneySys.UnityItemSys.Modules;

namespace project_pkdsim.USys.MoneySys.UnityItemSys.INVENTORY 
{
	public class InventorySystem : ITEMSDatabaseSys
	{
		public void Get_Inventory() 
		{
			Get_Items("", "", "");
		}
	}
}