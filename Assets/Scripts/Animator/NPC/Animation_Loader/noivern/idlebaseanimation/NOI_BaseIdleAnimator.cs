using project_pkdsim.Models.ANIMATOR.NPC.Noivern.idlebaseanimation.IdleSitting;
using project_pkdsim.Models.ANIMATOR.NPC.Noivern.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Noivern.idlebaseanimation
{
	public class NoivernIdleAnimatorController : MonoBehaviour 
	{
		private NOIIdleStanding Noivernidlestanding;
		
		private NOIIdleSitting Noivernidlesitting;
		
		public void	NOIIdleAnimatorController()
		{
			NOIIdleStandingAnimatorController();
			NOIIdleSittingAnimatorController();
		}
		private void NOIIdleStandingAnimatorController()
		{
			Noivernidlestanding.NOIIdleStandingController();
		}
		private void NOIIdleSittingAnimatorController()
		{
			Noivernidlesitting.NOIIdleSittingController();
		}
	}
}