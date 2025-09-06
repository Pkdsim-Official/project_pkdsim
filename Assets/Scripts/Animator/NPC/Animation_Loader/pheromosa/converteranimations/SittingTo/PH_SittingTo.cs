using project_pkdsim.ANIMATOR.NPC.Pheromosa.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.NPC.Pheromosa.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Pheromosa.converteranimations.SittingTo
{
	public class PHSittingTo : MonoBehaviour 
	{
		private PHSittingToStartWalking PheromosasittingToStartWalking;
		private PHSittingToStanding PheromosasittingToStanding;
		public void PHSittingToController()
		{
			PHSittingToStartWalking();
			PHSittingToStanding();
		}
		private void PHSittingToStartWalking()
		{
			PheromosasittingToStartWalking.PHSittingToStartWalkingController();
		}
		private void PHSittingToStanding()
		{
			PheromosasittingToStanding.PHSittingToStandingController();
		}

	}
}