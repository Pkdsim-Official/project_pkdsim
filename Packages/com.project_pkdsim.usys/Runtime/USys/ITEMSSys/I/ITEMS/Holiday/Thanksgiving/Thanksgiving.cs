using project_pkdsim.USys.HDSys.Modules.HolidaySys.ULoader.Assets.Modules.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Holiday.AssetsSorter.Thanksgiving
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