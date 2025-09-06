using project_pkdsim.ANIMATOR.NPC.Braixen.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Braixen.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Braixen.idlebaseanimation
{
	public class BraixenIdleAnimatorController : MonoBehaviour 
	{
		private BRIdleStanding BRidlestanding;
		
		private BRIdleSitting BRidlesitting;
		
		public void	BRIdleAnimatorController()
		{
			BRIdleStandingAnimatorController();
			BRIdleSittingAnimatorController();
		}
		private void BRIdleStandingAnimatorController()
		{
			BRidlestanding.BRIdleStandingController();
		}
		private void BRIdleSittingAnimatorController()
		{
			BRidlesitting.BRIdleSittingController();
		}
	}
}