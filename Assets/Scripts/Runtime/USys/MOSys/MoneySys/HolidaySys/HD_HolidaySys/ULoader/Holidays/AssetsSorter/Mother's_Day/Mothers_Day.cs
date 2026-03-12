using Project_Pkdsim.USys.MoneySys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Holidays.AssetsSorter.Mothers_Day
{
	public class Mothers_Day_IAssetsLoader : MonoBehaviour 
	{
		private ChangePricesI ChangePrices;
		public void LoadMothers_DayHAssets()
		{
			//Load Mother's Day Assets
		}

		public void LoadMothers_DaySales()
		{
			// Load Mother's Day Sales
			ChangePrices.LoadMothers_DayPrices();
		}
	}
}