using project_pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Assets.Modules.AssetsSorterI;
using project_pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Holidays;
using UnityEngine;

namespace project_pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader
{
	public class HDSys_Loader : MonoBehaviour
	{
		private HDA_ULoader HDAssetsSys_loader;
		private HDH_ULoader HDHolidaysSys_loader;
		public void HDSys_LoaderI()
		{
			HDA_Loader();
			HDH_Loader();
		}

		private void HDA_Loader()
		{
			var HDA_ULoader = new HDA_ULoader();
			HDA_ULoader.InitializeHolidayAsset();
		}
		private void HDH_Loader()
		{
			var HDH_ULoader = new HDH_ULoader();
			HDH_ULoader.InitializeHolidaysDatabase();
		}
	}
}