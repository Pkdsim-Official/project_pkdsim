using project_pkdsim.ANIMATOR.NPC.Vespiquen.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Vespiquen.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Vespiquen.idlebaseanimation
{
	public class Vespiquen_IdleAnimatorController : MonoBehaviour 
	{
		private VEIdleStanding VEidlestanding;
		
		private VE_IdleSitting VEidlesitting;
		
		public void	VE_IdleAnimatorController()
		{
			VEIdleStandingAnimatorController();
			VE_IdleSittingAnimatorController();
		}
		private void VEIdleStandingAnimatorController()
		{
			VEidlestanding.VEIdleStandingController();
		}
		private void VE_IdleSittingAnimatorController()
		{
			VEidlesitting.VE_IdleSittingController();
		}
	}
}