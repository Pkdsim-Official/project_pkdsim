using Project_Pkdsim.USys.UTPSys.UHousesTeleporterSys;
using UnityEngine;

namespace Project_Pkdsim.USys.UPTSys.Modules
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