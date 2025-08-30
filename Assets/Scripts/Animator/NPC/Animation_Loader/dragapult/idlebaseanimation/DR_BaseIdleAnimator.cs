using project_pkdsim.Models.ANIMATOR.NPC.Dragapult.idlebaseanimation.IdleSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Dragapult.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Dragapult.idlebaseanimation
{
	public class DragapultIdleAnimatorController : MonoBehaviour 
	{
		private DRIdleStanding Dragapultidlestanding;
		
		private DRIdleSitting Dragapultidlesitting;
		
		public void	DRIdleAnimatorController()
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