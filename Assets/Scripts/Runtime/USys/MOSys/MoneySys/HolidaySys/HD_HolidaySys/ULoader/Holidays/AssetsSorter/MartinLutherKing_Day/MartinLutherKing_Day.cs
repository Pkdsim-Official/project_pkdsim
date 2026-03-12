using Project_Pkdsim.USys.MoneySys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Holidays.AssetsSorter.MartinLutherKing_Day
{
	public class MartinLutherKing_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void LoadMartinLutherKingDayHAssets()
		{
			// Load Martin Luther King Day
		}

		public void LoadMartinLutherKing_DaySales()
		{
			// Load Martin Luther King Day Sales
			ChangePrices.LoadMartinLutherKingDayPrices();
		}
	}
}