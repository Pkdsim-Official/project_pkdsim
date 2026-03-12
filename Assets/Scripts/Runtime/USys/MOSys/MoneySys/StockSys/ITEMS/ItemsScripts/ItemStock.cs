using Project_Pkdsim.USys.MoneySys.Modules.STOCKSys.ITEMS.ItemsScripts.Necklaces.Modules;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.Modules.STOCKSys.ITEMS.ItemsScripts
{
	public class ItemStock : MonoBehaviour 
	{
		private NecklaceItemStock necklacesStock;

		public void NecklaceItemStocks()
		{
			necklacesStock = GetComponent<NecklaceItemStock>();
			necklacesStock.LoadNecklaceStocks();
		}
		
	}
}