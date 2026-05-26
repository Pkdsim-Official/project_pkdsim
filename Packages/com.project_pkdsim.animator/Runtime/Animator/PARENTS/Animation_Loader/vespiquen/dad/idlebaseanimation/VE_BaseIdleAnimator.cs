using project_pkdsim.ANIMATOR.Parents.Vespiquen.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.idlebaseanimation
{
	public class Vespiquen_IdleAnimatorController : MonoBehaviour 
	{
		private VEIdleStanding VEidlestanding;
		
		private VEIdleSitting VEidlesitting;
		
		public void	VE_IdleAnimatorController()
		{
			VEIdleStandingAnimatorController();
			VEIdleSittingAnimatorController();
		}
		private void VEIdleStandingAnimatorController()
		{
			VEidlestanding.VEIdleStandingController();
		}
		private void VEIdleSittingAnimatorController()
		{
			VEidlesitting.VEIdleSittingController();
		}
	}
}