using Project_Pkdsim.ANIMATOR.Npcs.Pheromosa.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Npcs.Pheromosa.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Pheromosa.idlebaseanimation
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