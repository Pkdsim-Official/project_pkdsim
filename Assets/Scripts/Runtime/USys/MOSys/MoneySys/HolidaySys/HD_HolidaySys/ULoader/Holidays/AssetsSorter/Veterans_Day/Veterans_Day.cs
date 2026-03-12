using Project_Pkdsim.USys.MoneySys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Holidays.AssetsSorter.Veterans_Day
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