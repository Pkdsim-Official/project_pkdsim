using project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.idlebaseanimation
{
	public class PheromosaParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private PHIdleStanding PHidlestanding;
		
		private PHIdleSitting PHidlesitting;
		
		public void	PH_IdleAnimatorController()
		{
			PHIdleStandingAnimatorController();
			PHIdleSittingAnimatorController();
		}
		private void PHIdleStandingAnimatorController()
		{
			PHidlestanding.PHIdleStandingController();
		}
		private void PHIdleSittingAnimatorController()
		{
			PHidlesitting.PHIdleSittingController();
		}
	}
}