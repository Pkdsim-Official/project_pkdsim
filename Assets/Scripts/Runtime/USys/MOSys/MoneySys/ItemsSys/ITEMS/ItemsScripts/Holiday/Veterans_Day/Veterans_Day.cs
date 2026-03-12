using Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Assets.Modules.AssetsSorterI;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Holiday.AssetsSorter.Veterans_Day
{
	public class Veterans_Day_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadVeterans_DayITHAssets()
		{
			//Load Veterans Day Item Assets
			HDA_ULoader.InitializeHolidayAsset("VeteransDayAssetKey"); // Load the holiday asset.
		}
	}
}