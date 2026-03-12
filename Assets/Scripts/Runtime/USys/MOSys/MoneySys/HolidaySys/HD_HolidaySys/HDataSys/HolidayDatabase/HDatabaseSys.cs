using Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys.HolidayDatabaseSys.Modules;

namespace Project_Pkdsim.USys.MoneySys.Modules.HOLIDAYSys
{
    public class HDatabaseSys : HolidayDatabase
    {
        public void HDatabaseSys_Init()
        {
            Get_Holidays();
        }
    }
}

