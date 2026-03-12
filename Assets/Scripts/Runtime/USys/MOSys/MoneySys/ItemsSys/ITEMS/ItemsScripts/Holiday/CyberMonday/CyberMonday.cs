using Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Assets.Modules.AssetsSorterI;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Holiday.AssetsSorter.CyberMonday
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