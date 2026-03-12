using Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Assets.Modules.AssetsSorterI;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Holiday.AssetsSorter.Memorial_Day
{
	public class Memorial_Day_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadMemorial_DayITHAssets()
		{
			//Load Memorial Day Item Assets
			HDA_ULoader.InitializeHolidayAsset("MemorialDayAssetKey"); // Load the holiday asset.
		}
	}
}