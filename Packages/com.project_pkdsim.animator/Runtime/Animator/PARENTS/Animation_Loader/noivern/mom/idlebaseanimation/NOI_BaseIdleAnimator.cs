using project_pkdsim.ANIMATOR.Parents.Noivern.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Noivern.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.Mom.idlebaseanimation
{
	public class NoivernParentMom_IdleAnimatorController : MonoBehaviour 
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