using Project_Pkdsim.ANIMATOR.Parents.Delphox.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Parents.Delphox.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Delphox.idlebaseanimation
{
	public class Delphox_IdleAnimatorController : MonoBehaviour 
	{
		private DLIdleStanding DLidlestanding;
		
		private DLIdleSitting DLidlesitting;
		
		public void	DL_IdleAnimatorController()
		{
			DLIdleStandingAnimatorController();
			DLIdleSittingAnimatorController();
		}
		private void DLIdleStandingAnimatorController()
		{
			DLidlestanding.DLIdleStandingController();
		}
		private void DLIdleSittingAnimatorController()
		{
			DLidlesitting.DLIdleSittingController();
		}
	}
}