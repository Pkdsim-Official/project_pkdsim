using project_pkdsim.Models.ANIMATOR.NPC.Hatterene.idlebaseanimation.IdleSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Hatterene.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Hatterene.idlebaseanimation
{
	public class HattereneIdleAnimatorController : MonoBehaviour 
	{
		private HATIdleStanding HATidlestanding;
		
		private HATIdleSitting HATidlesitting;
		
		public void	HATIdleAnimatorController()
		{
			HATIdleStandingAnimatorController();
			HATIdleSittingAnimatorController();
		}
		private void HATIdleStandingAnimatorController()
		{
			HATidlestanding.HATIdleStandingController();
		}
		private void HATIdleSittingAnimatorController()
		{
			HATidlesitting.HATIdleSittingController();
		}
	}
}