using Project_Pkdsim.USys.MoneySys.Modules.PRICESys;
using Project_Pkdsim.USys.MoneySys.Modules.STOCKSys;
using Project_Pkdsim.USys.MoneySys.Modules.STORESys;
using Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.Modules
{
	public class MoneySysI : MonoBehaviour
	{
		private PriceSys PriceSys;
		private StockSys StockSys;
		private StoreSys StoreSys;
		private HolidaySys HolidaySys;

		public void MoneySys_I()
		{
			GetPriceSys();
			GetStockSys();
			GetStoreSys();
		}
		private void GetPriceSys()
		{
			PriceSys.PriceSysI();
		}
		private void GetStockSys()
		{
			StockSys.StockSysI();
		}
		private void GetStoreSys()
		{
			StoreSys.StoreSysI();
		}
	}
}