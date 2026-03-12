using Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Assets.Modules.AssetsSorterI;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Holiday.AssetsSorter.NewYear
{
	public class NewYears_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadNewYears_ITHAssets()
		{
			//Load New Years Item Assets
			HDA_ULoader.InitializeHolidayAsset("NewYearAssetKey"); // Load the holiday asset.
		}
	}
}