using project_pkdsim.USys.MoneySys.Modules.HOLIDAYSys.ULoader;
using project_pkdsim.USys.MoneySys.Modules.HOLIDAYSys.Base;
using project_pkdsim.USys.MoneySys.Modules.HOLIDAYSys.HolidayDatabaseSys;
using UnityEngine;


namespace project_pkdsim.USys.MoneySys.Modules.HOLIDAYSys.Modules
{
	public class HD_HolidaySysI : MonoBehaviour
	{
		private HDataSys HDatabaseSys;

		private HDSys_Loader HDSys_Loader;

		public void  HD_HolidaySys_I() 
		{
			Get_HDSysLoader();
			Get_HDSysDatabase();
		}
		private void Get_HDSysLoader() 
		{
			HDSys_Loader.HDSys_LoaderI();
		}
		private void Get_HDSysDatabase() 
		{
			HDatabaseSys.HDataSysI();
		}
	}
}