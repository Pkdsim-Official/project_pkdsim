using project_pkdsim.USys.MOSys.Modules.MoneySys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace project_pkdsim.USys.HDSys.Modules.HolidaySys.ULoader.Holidays.AssetsSorter.CincoDeMayo
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