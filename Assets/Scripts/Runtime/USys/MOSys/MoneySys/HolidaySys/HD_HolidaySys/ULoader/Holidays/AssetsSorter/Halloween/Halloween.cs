using Project_Pkdsim.USys.MoneySys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Holidays.AssetsSorter.Halloween
{
	public class Halloween_IAssetLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void LoadHalloweenHAssetLoader()
		{
			// Load Halloween Asset
		}
		public void LoadHalloweenSales()
		{
			// Load Halloween Sales
			ChangePrices.LoadHalloweenPrices();
		}
	}
}