using Project_Pkdsim.USys.MoneySys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Holidays.AssetsSorter.Thanksgiving
{
	public class Thanksgiving_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void loadThanksgivingHAssetsLoader()
		{
			// Load Thanksgiving Assets
		}

		public void LoadThanksgivingSales()
		{
			// Load Thanksgiving Sales
			ChangePrices.LoadThanksgivingPrices();
		}
	}
}