using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.idlebaseanimation.IdleSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Beedrill.idlebaseanimation
{
	public class BeedrillIdleAnimatorController : MonoBehaviour 
	{
		private BEIdleStanding Beedrillidlestanding;
		
		private BEIdleSitting Beedrillidlesitting;
		
		public void	BEIdleAnimatorController()
		{
			BEIdleStandingAnimatorController();
			BEIdleSittingAnimatorController();
		}
		private void BEIdleStandingAnimatorController()
		{
			Beedrillidlestanding.BEIdleStandingController();
		}
		private void BEIdleSittingAnimatorController()
		{
			Beedrillidlesitting.BEIdleSittingController();
		}
	}
}