using project_pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Assets.Modules.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Holiday.AssetsSorter.CincoDeMayo
{
	public class CincoDeMayo_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadCincoDeMayo_ITHAssets()
		{
			//Load Cinco De Mayo Item Assets
			HDA_ULoader.InitializeHolidayAsset("CincoDeMayoAssetKey"); // Load the holiday asset.
		}
	}
}