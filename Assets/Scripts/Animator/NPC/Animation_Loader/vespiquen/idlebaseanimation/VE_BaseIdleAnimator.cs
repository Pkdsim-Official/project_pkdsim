using project_pkdsim.ANIMATOR.NPC.Vespiquen.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Vespiquen.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Vespiquen.idlebaseanimation
{
	public class VespiquenIdleAnimatorController : MonoBehaviour 
	{
		private VEIdleStanding VEidlestanding;
		
		private VEIdleSitting VEidlesitting;
		
		public void	VEIdleAnimatorController()
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