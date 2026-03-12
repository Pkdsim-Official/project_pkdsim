using Project_Pkdsim.USys.MoneySys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Holidays.AssetsSorter.Memorial_Day
{
	public class Memorial_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void LoadMemorial_DayHAssetLoader()
		{
			// Load Memorial Day assets
		}

		public void LoadMemorial_DaySales()
		{
			// Load Memorial Day Sales
			ChangePrices.LoadMemorial_DayPrices();
		}
	}
}