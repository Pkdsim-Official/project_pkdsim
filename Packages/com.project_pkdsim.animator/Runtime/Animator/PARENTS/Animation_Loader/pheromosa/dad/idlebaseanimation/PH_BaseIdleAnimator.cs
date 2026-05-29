using project_pkdsim.ANIMATOR.Parents.Pheromosa.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Pheromosa.idlebaseanimation
{
	public class PheromosaParentDad_IdleAnimatorController : MonoBehaviour 
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