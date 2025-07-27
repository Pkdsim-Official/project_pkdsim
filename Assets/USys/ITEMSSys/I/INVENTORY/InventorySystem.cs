using project_pkdsim.Assets.USys.UItemsSystemSys.I;

namespace project_pkdsim.Assets.USys.UItemsSystemSys.INVENTORY 
{
	public class InventorySystem : ITEMSDatabaseSys
	{
		public void Get_Inventory(string value) 
		{
			Get_Items(value);
		}
	}
}