using project_pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Assets.Modules.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Holiday.AssetsSorter.Columbus_Day
{
	public class Columbus_Day_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadColumbus_DayITHAssets()
		{
			//Load Columbus Day Item Assets
			HDA_ULoader.InitializeHolidayAsset("ColumbusDayAssetKey"); // Load the holiday asset.
		}
	}
}