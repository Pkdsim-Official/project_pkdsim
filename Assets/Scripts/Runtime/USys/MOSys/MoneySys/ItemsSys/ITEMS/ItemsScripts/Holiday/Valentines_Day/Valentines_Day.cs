using Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Assets.Modules.AssetsSorterI;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Holiday.AssetsSorter.Valentines_Day
{
	public class Valentines_Day_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadValentines_DayITHAssets()
		{
			//Load Valentines_Day Item Assets
			HDA_ULoader.InitializeHolidayAsset("ValentinesDayAssetKey"); // Load the holiday asset.
		}
	}
}