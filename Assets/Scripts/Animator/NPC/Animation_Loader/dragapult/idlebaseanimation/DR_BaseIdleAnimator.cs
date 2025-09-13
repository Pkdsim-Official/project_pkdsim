using project_pkdsim.ANIMATOR.NPC.Dragapult.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Dragapult.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Dragapult.idlebaseanimation
{
	public class Dragapult_IdleAnimatorController : MonoBehaviour 
	{
		private DRIdleStanding Dragapultidlestanding;
		
		private DR_IdleSitting Dragapultidlesitting;
		
		public void	DR_IdleAnimatorController()
		{
			DRIdleStandingAnimatorController();
			DR_IdleSittingAnimatorController();
		}
		private void DRIdleStandingAnimatorController()
		{
			Dragapultidlestanding.DRIdleStandingController();
		}
		private void DR_IdleSittingAnimatorController()
		{
			Dragapultidlesitting.DR_IdleSittingController();
		}
	}
}