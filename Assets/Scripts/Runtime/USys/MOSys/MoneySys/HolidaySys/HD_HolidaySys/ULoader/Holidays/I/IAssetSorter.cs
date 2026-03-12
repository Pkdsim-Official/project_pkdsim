using Project_Pkdsim.USys.MoneySys.UnityItemSys.Modules.ITEMS.ItemsScripts.Holiday;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Holidays.Modules
{
	public class IAssetSorter : MonoBehaviour
	{
		private HolidayItem HolidayItems;
		public void LoadAllHolidays()
		{
			HolidayItems.LoadItems("");
		}
	}
}
