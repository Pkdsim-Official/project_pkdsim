using Project_Pkdsim.USys.MoneySys.Modules.STOCKSys.ITEMS.ItemsScripts;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.Modules.STOCKSys
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