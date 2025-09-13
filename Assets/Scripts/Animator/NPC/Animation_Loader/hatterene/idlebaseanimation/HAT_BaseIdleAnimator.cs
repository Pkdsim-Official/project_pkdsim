using project_pkdsim.ANIMATOR.NPC.Hatterene.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Hatterene.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Hatterene.idlebaseanimation
{
	public class Hatterene_IdleAnimatorController : MonoBehaviour 
	{
		private HATIdleStanding HATidlestanding;
		
		private HAT_IdleSitting HATidlesitting;
		
		public void	HAT_IdleAnimatorController()
		{
			HATIdleStandingAnimatorController();
			HAT_IdleSittingAnimatorController();
		}
		private void HATIdleStandingAnimatorController()
		{
			HATidlestanding.HATIdleStandingController();
		}
		private void HAT_IdleSittingAnimatorController()
		{
			HATidlesitting.HAT_IdleSittingController();
		}
	}
}