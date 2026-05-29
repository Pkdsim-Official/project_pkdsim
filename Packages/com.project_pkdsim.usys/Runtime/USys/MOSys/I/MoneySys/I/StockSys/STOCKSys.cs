using project_pkdsim.USys.MOSys.Modules.MoneySys.Modules.STOCKSys.ITEMS.ItemsScripts;
using UnityEngine;

namespace project_pkdsim.USys.MOSys.Modules.MoneySys.Modules.STOCKSys
{
	public class StockSys : MonoBehaviour 
	{
		public ItemStock itemsStockSys;
		private void ItemStockSysI () 
		{
			itemsStockSys.NecklaceItemStocks();
		}
		public void StockSysI() 
		{
			ItemStockSysI();
		}
	}
}