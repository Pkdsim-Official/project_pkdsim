using project_pkdsim.USys.MoneySys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace project_pkdsim.USys.HolidaySys.ULoader.Holidays.AssetsSorter.CyberMonday
{
	public class CyberMonday_IAssetLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void LoadCyberMondayHAssetLoader()
		{
			// Load Cyber Monday Assets
		}
		public void LoadCyberMondaySales()
		{
			// Load Cyber Monday Sales
			ChangePrices.LoadCyberMondayPrices();
		}
	}
}