using Project_Pkdsim.USys.MoneySys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Holidays.AssetsSorter.NewYear
{
	public class NewYears_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void LoadNewYearsHAssetsLoader()
		{
			// Load New Years Assets
		}

		public void LoadNewYearsSales()
		{
			// Load New Years Sales
			ChangePrices.LoadNewYearPrices();
		}
	}
}