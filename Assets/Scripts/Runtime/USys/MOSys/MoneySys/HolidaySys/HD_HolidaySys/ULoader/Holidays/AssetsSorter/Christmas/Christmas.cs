using Project_Pkdsim.USys.MoneySys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Holidays.AssetsSorter.Christmas
{
	public class Christmas_IAssetLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void loadChristmasIAssetsLoader()
		{
			// Load Christmas Assets
		}

		public void LoadChristmasSales()
		{
			// Load Christmas Sales
			ChangePrices.LoadChristmasPrices();
		}
	}
}