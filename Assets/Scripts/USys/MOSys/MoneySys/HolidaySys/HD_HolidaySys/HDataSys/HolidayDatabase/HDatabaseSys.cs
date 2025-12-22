using project_pkdsim.USys.MoneySys.Modules.HOLIDAYSys.HolidayDatabaseSys.Modules;

namespace project_pkdsim.USys.MoneySys.Modules.HOLIDAYSys
{
    public class HDatabaseSys : HolidayDatabase
    {
        public void HDatabaseSys_Init()
        {
            Get_Holidays();
        }
    }
}

