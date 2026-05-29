using project_pkdsim.USys.ADATSys.Modules.AntiDateAndTimeSys.Modules;

namespace project_pkdsim.USys.ADATSys.Modules
{
	public class ADATSysI
	{
        AntiDateATimeSys AntiDateATimeSys;
		public void ADATSys_I()
        {
            AntiDateATimeSys.AntiDateAndTimeSysI();
        }
	}
}