using Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Assets.Modules.AssetsSorterI;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Holiday.AssetsSorter.Fathers_Day
{
	public class Fathers_Day_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadFathers_DayITHAssets()
		{
			//Load Fathers Day Item Assets
			HDA_ULoader.InitializeHolidayAsset("FathersDayAssetKey"); // Load the holiday asset.
		}
	}
}