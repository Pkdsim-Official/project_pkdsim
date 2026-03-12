using Project_Pkdsim.USys.MoneySys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Holidays.AssetsSorter.Columbus_Day
{
	public class Columbus_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void loadColumbusHAssets()
		{
			// Load Columbus Day Assets
		}

		public void LoadColumbus_DaySales()
		{
			// Load Columbus Day Sales
			ChangePrices.LoadColumbus_DayPrices();
		}		
	}
}