using project_pkdsim.USys.HDSys.Modules.HolidaySys.HolidayDatabaseSys.Modules;

namespace project_pkdsim.USys.HDSys.Modules.HolidaySys
{
    public class HDatabaseSys : HolidayDatabase
    {
        public void HDatabaseSys_Init()
        {
            Get_Holidays();
        }
    }
}

