using project_pkdsim.USys.HolidaySys.ULoader.Assets.Modules.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Holiday.AssetsSorter.Valentines_Day
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