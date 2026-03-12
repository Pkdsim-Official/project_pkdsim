using Project_Pkdsim.USys.UTPSys.UHousesTeleporterSys;
using UnityEngine;

namespace Project_Pkdsim.USys.PlayerTeleporterSys
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