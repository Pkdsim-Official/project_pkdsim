using project_pkdsim.USys.MoneySys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace project_pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Holidays.AssetsSorter.Thanksgiving
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