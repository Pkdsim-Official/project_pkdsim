using project_pkdsim.ANIMATOR.NPC.Absol.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Absol.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Absol.idlebaseanimation
{
	public class Absol_IdleAnimatorController : MonoBehaviour 
	{
		private ABIdleStanding AbsolIdlestanding;
		
		private AB_IdleSitting AbsolIdlesitting;
		
		public void	AB_IdleAnimatorController()
		{
			AB_IdleStandingAnimatorController();
			AB_IdleSittingAnimatorController();
		}
		private void AB_IdleStandingAnimatorController()
		{
			AbsolIdlestanding.ABIdleStandingController();
		}
		private void AB_IdleSittingAnimatorController()
		{
			AbsolIdlesitting.AB_IdleSittingController();
		}
	}
}