using Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.AntiHolidayChecker;
using Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys;
using UnityEngine;

namespace Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys
{
	public class UnityHolidaySysI : MonoBehaviour 
	{
		private HD_HolidaySys HolidaySys;
		private AntiHolidayCheatChecker AntiHolidayCheatChecker;
		public void HDSys_I()
		{
			Get_HD_HolidaySys();
			Get_AntiHolidayCheatChecker();
		}
		private void Get_HD_HolidaySys()
		{
			HolidaySys.HDSysI();
		}
		private void Get_AntiHolidayCheatChecker()
		{
			AntiHolidayCheatChecker.AntiHolidayCheckerI();
		}
	}
}