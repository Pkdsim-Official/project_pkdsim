using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Braixen.Dad.idlebaseanimation
{
	public class BraixenParentDad_IdleAnimatorController : MonoBehaviour 
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