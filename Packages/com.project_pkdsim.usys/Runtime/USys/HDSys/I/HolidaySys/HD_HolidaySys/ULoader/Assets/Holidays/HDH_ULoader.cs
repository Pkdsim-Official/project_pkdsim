using project_pkdsim.USys.HDSys.Modules.HolidaySys.ULoader.Holidays.Modules;

namespace project_pkdsim.USys.HDSys.Modules.HolidaySys.ULoader.Holidays
{
	public class HDH_ULoader : IAssetSorter
	{
		public void InitializeHolidaysDatabase()
		{
			LoadAllHolidays();
		}
	}
}