using project_pkdsim.USys.UTPSys.UHousesTeleporterSys;
using UnityEngine;

namespace project_pkdsim.USys.UPTSys.Modules
{
    public class UPTSysI : MonoBehaviour 
	{
		private UHTeleporterSys UHTeleporterSys;
		public void UTPSysI()
		{
			UHTeleporterSys.UHTPSysI();
		}
	}
}