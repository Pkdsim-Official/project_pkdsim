using project_pkdsim.ANIMATOR.NPC.Pheromosa.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Pheromosa.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Pheromosa.idlebaseanimation
{
	public class PheromosaIdleAnimatorController : MonoBehaviour 
	{
		private PHIdleStanding PHidlestanding;
		
		private PHIdleSitting PHidlesitting;
		
		public void	PHIdleAnimatorController()
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