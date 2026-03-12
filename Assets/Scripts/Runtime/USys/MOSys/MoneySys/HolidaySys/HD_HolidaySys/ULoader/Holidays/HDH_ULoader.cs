using Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Holidays.Modules;

namespace Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader.Holidays
{
	public class HDH_ULoader : IAssetSorter
	{
		public void InitializeHolidaysDatabase()
		{
			LoadAllHolidays();
		}
	}
}