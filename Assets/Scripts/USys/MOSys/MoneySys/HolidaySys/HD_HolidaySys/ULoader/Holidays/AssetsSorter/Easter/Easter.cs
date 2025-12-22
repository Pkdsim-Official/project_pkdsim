using project_pkdsim.USys.MoneySys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace project_pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Holidays.AssetsSorter.Easter
{
	public class Easter_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void LoadEasterHAssets()
		{
			// Load Easter Assets
		}
		public void LoadEasterSales()
		{
			// Load Easter Sales
			ChangePrices.LoadEasterPrices();
		}
	}
}