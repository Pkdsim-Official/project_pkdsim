using project_pkdsim.ANIMATOR.Parents.Braixen.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Braixen.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Braixen.idlebaseanimation
{
	public class Braixen_IdleAnimatorController : MonoBehaviour 
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