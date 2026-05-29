using project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.SittingTo
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