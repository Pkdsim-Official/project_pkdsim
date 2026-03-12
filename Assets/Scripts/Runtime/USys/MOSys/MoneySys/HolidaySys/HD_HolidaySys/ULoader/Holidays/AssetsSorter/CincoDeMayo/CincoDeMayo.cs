using Project_Pkdsim.USys.MoneySys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Holidays.AssetsSorter.CincoDeMayo
{
	public class CincoDeMayo_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public static void LoadCincoDeMayoHAssets()
		{
			// Load Cinco De Mayo Assets
		}
		public void LoadCincoDeMayo_Prices()
		{
			// Load Cinco De Mayo Prices
			ChangePrices.LoadCincoDeMayoPrices();
		}
	}
}