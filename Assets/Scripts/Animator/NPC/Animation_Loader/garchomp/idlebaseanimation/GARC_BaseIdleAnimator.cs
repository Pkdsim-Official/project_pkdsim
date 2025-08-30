using project_pkdsim.Models.ANIMATOR.NPC.Garchomp.idlebaseanimation.IdleSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Garchomp.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Garchomp.idlebaseanimation
{
	public class GarchompIdleAnimatorController : MonoBehaviour 
	{
		private GARCIdleStanding Garchompidlestanding;
		
		private GARCIdleSitting Garchompidlesitting;
		
		public void	GARCIdleAnimatorController()
		{
			GARCIdleStandingAnimatorController();
			GARCIdleSittingAnimatorController();
		}
		private void GARCIdleStandingAnimatorController()
		{
			Garchompidlestanding.GARCIdleStandingController();
		}
		private void GARCIdleSittingAnimatorController()
		{
			Garchompidlesitting.GARCIdleSittingController();
		}
	}
}