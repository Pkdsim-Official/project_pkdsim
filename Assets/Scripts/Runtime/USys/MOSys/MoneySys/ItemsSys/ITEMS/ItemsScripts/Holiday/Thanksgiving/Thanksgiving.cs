using Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Assets.Modules.AssetsSorterI;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Holiday.AssetsSorter.Thanksgiving
{
	public class Thanksgiving_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void loadThanksgivingITHAssets()
		{
			//Load Thanksgiving Item Assets
			HDA_ULoader.InitializeHolidayAsset("ThanksgivingAssetKey"); // Load the holiday asset.
		}
	}
}