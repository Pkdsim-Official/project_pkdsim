using project_pkdsim.USys.HolidaySys.ULoader.Assets.Modules.AssetsSorterI;
using UnityEngine;

namespace project_pkdsim.USys.UItemsSystemSys.Modules.ITEMS.ItemsScripts.Holiday.AssetsSorter.CyberMonday
{
	public class CyberMonday_ITAssets : MonoBehaviour
	{
		private HDA_ULoader holidayLoader;
		public void LoadCyberMonday_ITHAssets()
		{
			//Load Cyber Monday Item Assets
			HDA_ULoader.InitializeHolidayAsset("CyberMondayAssetKey"); // Load the holiday asset.
		}
	}
}