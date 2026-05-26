using project_pkdsim.USys.HolidaySys.ULoader.Holidays.Modules;

namespace project_pkdsim.USys.HolidaySys.ULoader.Holidays
{
	public class HDH_ULoader : IAssetSorter
	{
		public void InitializeHolidaysDatabase()
		{
			LoadAllHolidays();
		}
	}
}