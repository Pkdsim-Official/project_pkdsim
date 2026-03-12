using Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.Base;

namespace Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.HolidayDatabaseSys
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