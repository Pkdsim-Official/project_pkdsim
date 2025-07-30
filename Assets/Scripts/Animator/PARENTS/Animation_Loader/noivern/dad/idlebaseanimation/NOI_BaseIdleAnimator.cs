using project_pkdsim.ANIMATOR.Parents.Noivern.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Noivern.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.idlebaseanimation
{
	public class Noivern_IdleAnimatorController : MonoBehaviour 
	{
		private NOIIdleStanding Noivernidlestanding;
		
		private NOIIdleSitting Noivernidlesitting;
		
		public void	NOI_IdleAnimatorController()
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