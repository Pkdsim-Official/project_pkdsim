using project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.idlebaseanimation
{
	public class DelphoxParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private DRIdleStanding Dragapultidlestanding;
		
		private DRIdleSitting Dragapultidlesitting;
		
		public void	DR_IdleAnimatorController()
		{
			DRIdleStandingAnimatorController();
			DRIdleSittingAnimatorController();
		}
		private void DRIdleStandingAnimatorController()
		{
			Dragapultidlestanding.DRIdleStandingController();
		}
		private void DRIdleSittingAnimatorController()
		{
			Dragapultidlesitting.DRIdleSittingController();
		}
	}
}