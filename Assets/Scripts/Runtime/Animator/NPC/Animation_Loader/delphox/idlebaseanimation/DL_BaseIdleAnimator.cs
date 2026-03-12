using Project_Pkdsim.ANIMATOR.Npcs.Delphox.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Delphox.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Delphox.idlebaseanimation
{
	public class Delphox_IdleAnimatorController : MonoBehaviour 
	{
		private DLIdleStanding DLidlestanding;
		
		private DL_IdleSitting DLidlesitting;
		
		public void	DL_IdleAnimatorController()
		{
			DLIdleStandingAnimatorController();
			DL_IdleSittingAnimatorController();
		}
		private void DLIdleStandingAnimatorController()
		{
			DLidlestanding.DLIdleStandingController();
		}
		private void DL_IdleSittingAnimatorController()
		{
			DLidlesitting.DL_IdleSittingController();
		}
	}
}