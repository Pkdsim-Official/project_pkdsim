using Project_Pkdsim.USys.MoneySys.Modules.STORESys.Modules.Buy;
using Project_Pkdsim.USys.MoneySys.Modules.STORESys.Modules.Sell;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.Modules.STORESys.Modules
{
	public class STORESysI : MonoBehaviour 
	{
		private BuyItem BuyItems;
		private SellItem SellItems;

		private void BuyItem()
		{
			BuyItems.BuyItemI();
		}
		private void SellItem()
		{
			SellItems.SellItemI();
		}
		public void StoreSys_I()
		{
			SellItem();
			BuyItem();
		}
	}
}