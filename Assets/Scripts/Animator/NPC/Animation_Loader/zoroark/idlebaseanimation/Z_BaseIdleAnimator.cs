using project_pkdsim.Models.ANIMATOR.NPC.Zoroark.idlebaseanimation.IdleSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Zoroark.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Zoroark.idlebaseanimation
{
	public class ZoroarkIdleAnimatorController : MonoBehaviour 
	{
		private ZIdleStanding Zoroarkidlestanding;
		
		private ZIdleSitting Zoroarkidlesitting;
		
		public void	ZIdleAnimatorController()
		{
			ZIdleStandingAnimatorController();
			ZIdleSittingAnimatorController();
		}
		private void ZIdleStandingAnimatorController()
		{
			Zoroarkidlestanding.ZIdleStandingController();
		}
		private void ZIdleSittingAnimatorController()
		{
			Zoroarkidlesitting.ZIdleSittingController();
		}
	}
}