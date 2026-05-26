using project_pkdsim.USys.HolidaySys.Base;

namespace project_pkdsim.USys.HolidaySys.HolidayDatabaseSys
{
	public class HDataSys : HDatabaseSys
	{
		// Use this for initialization
		public void HDataSysI()
		{
			Get_Holiday_Database();
		}
		private void Get_Holiday_Database()
		{
			HDatabaseSys_Init();
		}
	}
}