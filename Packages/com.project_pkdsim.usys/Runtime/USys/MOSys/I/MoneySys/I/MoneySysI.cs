using project_pkdsim.USys.MOSys.Modules.MoneySys.Modules.PRICESys;
using project_pkdsim.USys.MOSys.Modules.MoneySys.Modules.STOCKSys;
using project_pkdsim.USys.MOSys.Modules.MoneySys.Modules.STORESys;
using UnityEngine;

namespace project_pkdsim.USys.MOSys.Modules.MoneySys.Modules
{
	public class MoneySysI : MonoBehaviour
	{
		private PriceSys PriceSys;
		private StockSys StockSys;
		private StoreSys StoreSys;

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