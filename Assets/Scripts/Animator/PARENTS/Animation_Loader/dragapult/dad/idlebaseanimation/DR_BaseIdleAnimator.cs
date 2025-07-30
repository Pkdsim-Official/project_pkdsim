using project_pkdsim.ANIMATOR.Parents.Dragapult.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Dragapult.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Dragapult.idlebaseanimation
{
	public class Dragapult_IdleAnimatorController : MonoBehaviour 
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