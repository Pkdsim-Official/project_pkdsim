using project_pkdsim.ANIMATOR.Parents.Braixen.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Braixen.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Braixen.Mom.idlebaseanimation
{
	public class BraixenParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private BRIdleStanding BRidlestanding;
		
		private BRIdleSitting BRidlesitting;
		
		public void	BR_IdleAnimatorController()
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