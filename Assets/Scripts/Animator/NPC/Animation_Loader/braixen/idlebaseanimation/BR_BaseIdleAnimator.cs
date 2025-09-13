using project_pkdsim.ANIMATOR.NPC.Braixen.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Braixen.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Braixen.idlebaseanimation
{
	public class Braixen_IdleAnimatorController : MonoBehaviour 
	{
		private BRIdleStanding BRidlestanding;
		
		private BR_IdleSitting BRidlesitting;
		
		public void	BR_IdleAnimatorController()
		{
			BRIdleStandingAnimatorController();
			BR_IdleSittingAnimatorController();
		}
		private void BRIdleStandingAnimatorController()
		{
			BRidlestanding.BRIdleStandingController();
		}
		private void BR_IdleSittingAnimatorController()
		{
			BRidlesitting.BR_IdleSittingController();
		}
	}
}