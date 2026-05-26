using project_pkdsim.ANIMATOR.NPC.Noivern.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Noivern.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Noivern.idlebaseanimation
{
	public class Noivern_IdleAnimatorController : MonoBehaviour 
	{
		private NOIIdleStanding Noivernidlestanding;
		
		private NOI_IdleSitting Noivernidlesitting;
		
		public void	NOI_IdleAnimatorController()
		{
			NOIIdleStandingAnimatorController();
			NOI_IdleSittingAnimatorController();
		}
		private void NOIIdleStandingAnimatorController()
		{
			Noivernidlestanding.NOIIdleStandingController();
		}
		private void NOI_IdleSittingAnimatorController()
		{
			Noivernidlesitting.NOI_IdleSittingController();
		}
	}
}