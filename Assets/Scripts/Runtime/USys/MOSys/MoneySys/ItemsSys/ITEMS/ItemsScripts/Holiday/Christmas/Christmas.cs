using Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Assets.Modules.AssetsSorterI;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Holiday.AssetsSorter.Christmas
{
	public class Christmas_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadChristmas_ITHAssets()
		{
			//Load Christmas Item Assets
			HDA_ULoader.InitializeHolidayAsset("ChristmasAssetKey"); // Load the holiday asset.
		}
	}
}