using Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Assets.Modules.AssetsSorterI;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Holiday.AssetsSorter.Easter
{
	public class Easter_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadEaster_ITHAssets()
		{
			//Load Easter Item Assets
			HDA_ULoader.InitializeHolidayAsset("EasterAssetKey"); // Load the holiday asset.
		}
	}
}