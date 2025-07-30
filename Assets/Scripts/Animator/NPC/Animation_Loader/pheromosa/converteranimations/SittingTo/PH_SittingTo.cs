using project_pkdsim.ANIMATOR.NPC.Pheromosa.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.NPC.Pheromosa.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Pheromosa.converteranimations.SittingTo
{
	public class PH_SittingTo : MonoBehaviour 
	{
		private PH_SittingToStartWalking PheromosasittingToStartWalking;
		private PH_SittingToStanding PheromosasittingToStanding;
		public void PH_SittingToController()
		{
			PH_SittingToStartWalking();
			PH_SittingToStanding();
		}
		private void PH_SittingToStartWalking()
		{
			PheromosasittingToStartWalking.PH_SittingToStartWalkingController();
		}
		private void PH_SittingToStanding()
		{
			PheromosasittingToStanding.PH_SittingToStandingController();
		}

	}
}