using project_pkdsim.ANIMATOR.NPC.Pheromosa.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.NPC.Pheromosa.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Pheromosa.idlebaseanimation
{
	public class Pheromosa_IdleAnimatorController : MonoBehaviour 
	{
		private PHIdleStanding PHidlestanding;
		
		private PH_IdleSitting PHidlesitting;
		
		public void	PH_IdleAnimatorController()
		{
			PHIdleStandingAnimatorController();
			PH_IdleSittingAnimatorController();
		}
		private void PHIdleStandingAnimatorController()
		{
			PHidlestanding.PHIdleStandingController();
		}
		private void PH_IdleSittingAnimatorController()
		{
			PHidlesitting.PH_IdleSittingController();
		}
	}
}