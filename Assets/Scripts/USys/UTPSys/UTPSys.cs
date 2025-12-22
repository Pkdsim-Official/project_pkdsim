using project_pkdsim.USys.UTPSys.UHousesTeleporterSys;
using UnityEngine;

namespace project_pkdsim.USys.PlayerTeleporterSys
{
	public class UPTSys : MonoBehaviour 
	{
		private UHTeleporterSys UHTeleporterSys;
		public void UTPSysI()
		{
			UHTeleporterSys.UHTPSysI();
		}
	}
}