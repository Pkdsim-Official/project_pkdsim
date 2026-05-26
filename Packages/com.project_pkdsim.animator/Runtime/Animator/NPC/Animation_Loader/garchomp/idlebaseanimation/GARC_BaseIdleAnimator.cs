using project_pkdsim.ANIMATOR.NPC.Garchomp.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Garchomp.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Garchomp.idlebaseanimation
{
	public class Garchomp_IdleAnimatorController : MonoBehaviour 
	{
		private GARC_IdleStanding Garchompidlestanding;
		
		private GARC_IdleSitting Garchompidlesitting;
		
		public void	GARC_IdleAnimatorController()
		{
			GARC_IdleStandingAnimatorController();
			GARC_IdleSittingAnimatorController();
		}
		private void GARC_IdleStandingAnimatorController()
		{
			Garchompidlestanding.GARC_IdleStandingController();
		}
		private void GARC_IdleSittingAnimatorController()
		{
			Garchompidlesitting.GARC_IdleSittingController();
		}
	}
}