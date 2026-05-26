using project_pkdsim.ANIMATOR.Parents.Pheromosa.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Pheromosa.converteranimations.WalkingTo
{
	public class PHWalkingTo : MonoBehaviour 
	{
		private PHWalkingToSitting PheromosaWalkingToSitting;
		private PHWalkingToStanding PheromosaWalkingToStanding;
		public void PHWalkingToController() 
		{
			Load_PHWalkingToSitting();
			Load_PHWalkingToStanding();
		}
		private void Load_PHWalkingToStanding()
		{
			PheromosaWalkingToStanding.PHWalkingToStandingController();
		}
		private void Load_PHWalkingToSitting()
		{
			PheromosaWalkingToSitting.PHWalkingToSittingController();
		}
	}
}