using project_pkdsim.ANIMATOR.NPC.Beedrill.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Beedrill.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Beedrill.idlebaseanimation
{
	public class BeedrillIdleAnimatorController : MonoBehaviour 
	{
		private BE_IdleStanding BeedrillIdlestanding;
		
		private BE_IdleSitting BeedrillIdlesitting;
		
		public void	BE_IdleAnimatorController()
		{
			BE_IdleStandingAnimatorController();
			BE_IdleSittingAnimatorController();
		}
		private void BE_IdleStandingAnimatorController()
		{
			BeedrillIdlestanding.BE_IdleStandingController();
		}
		private void BE_IdleSittingAnimatorController()
		{
			BeedrillIdlesitting.BE_IdleSittingController();
		}
	}
}