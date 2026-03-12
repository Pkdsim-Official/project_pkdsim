using Project_Pkdsim.USys.MoneySys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Holidays.AssetsSorter.BlackFriday
{
	public class BlackFriday_IAssetLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void loadBlackFridayHAssetLoader()
		{
			// Load Black Friday Assets
		}
		public void LoadBlackFridaySales()
		{
			// Load Black Friday Sales
			ChangePrices.LoadBlackFridayPrices();
		}
	}
}