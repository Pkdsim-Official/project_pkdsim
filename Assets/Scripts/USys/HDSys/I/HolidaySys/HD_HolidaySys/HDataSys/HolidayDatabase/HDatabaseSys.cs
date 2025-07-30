using project_pkdsim.USys.HolidaySys.HolidayDatabaseSys.Modules;

namespace project_pkdsim.USys.HolidaySys
{
    public class HDatabaseSys : HolidayDatabase
    {
        public void HDatabaseSys_Init()
        {
            Get_Holidays();
        }
    }
}

