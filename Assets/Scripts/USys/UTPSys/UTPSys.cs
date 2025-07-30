using project_pkdsim.USys.UTPSys.UHousesTeleporterSys;
using UnityEngine;

namespace project_pkdsim.USys.UTeleporterSys
{
	public class UnityTeleporterSys : MonoBehaviour 
	{
		private UHTeleporterSys UHTeleporterSys;
		public void UTPSysI()
		{
			UHTeleporterSys.UHTPSysI();
		}
	}
}