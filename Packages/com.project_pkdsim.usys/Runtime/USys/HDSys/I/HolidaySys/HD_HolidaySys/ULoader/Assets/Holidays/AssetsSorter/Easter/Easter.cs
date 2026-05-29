using project_pkdsim.USys.MOSys.Modules.MoneySys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace project_pkdsim.USys.HDSys.Modules.HolidaySys.ULoader.Holidays.AssetsSorter.Easter
{
	public class Easter_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void LoadEasterHAssets()
		{
			// Load Easter Assets
		}
		public void LoadEasterSales()
		{
			// Load Easter Sales
			ChangePrices.LoadEasterPrices();
		}
	}
}