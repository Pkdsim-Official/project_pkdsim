using project_pkdsim.USys.MoneySys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace project_pkdsim.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Veterans_Day
{
	public class Veterans_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void loadVeterans_DayHAssets()
		{
			//Load Veterans Day Assets
		}

		public void LoadVeterans_DaySales()
		{
			//Load Veterans Day Sales
			ChangePrices.LoadVeterans_DayPrices();
		}
	}
}