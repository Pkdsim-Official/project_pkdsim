using project_pkdsim.Models.ANIMATOR.NPC.Lucario.idlebaseanimation.IdleSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Lucario.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Lucario.idlebaseanimation
{
	public class LucarioIdleAnimatorController : MonoBehaviour 
	{
		private LUCAIdleStanding LucarioIdleStanding;
		
		private LUCAIdleSitting LucarioIdleSitting;
		
		public void	LUCAIdleAnimatorController()
		{
			LUCAIdleStandingAnimatorController();
			LUCAIdleSittingAnimatorController();
		}
		private void LUCAIdleStandingAnimatorController()
		{
			LucarioIdleStanding.LUCAIdleStandingController();
		}
		private void LUCAIdleSittingAnimatorController()
		{
			LucarioIdleSitting.LUCAIdleSittingController();
		}
	}
}