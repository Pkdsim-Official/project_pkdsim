using Project_Pkdsim.USys.MoneySys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Holidays.AssetsSorter.Fathers_Day
{
	public class Fathers_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void LoadFathers_DayHAssetsLoader()
		{
			// Load Fathers Day Assets
		}
		public void LoadFathers_DaySales()
		{
			// Load Fathers Day Day Sales
			ChangePrices.LoadFathers_DayPrices();
		}
	}
}