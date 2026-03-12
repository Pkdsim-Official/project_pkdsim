using Project_Pkdsim.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.WalkingTo
{
		public class PHParentMom_WalkingTo : MonoBehaviour 
	{
		private PHParentMom_WalkingToSitting PheromosaParentMomWalkingToSitting;
		private PHParentMom_WalkingToStanding PheromosaParentMomWalkingToStanding;
		public void PHParentMom_WalkingToController()
		{
			PHParentMom_WalkingToStartWalking();
			PHParentMom_WalkingToStanding();
		}
		private void PHParentMom_WalkingToStartWalking()
		{
			PheromosaParentMomWalkingToSitting.PHParentMom_WalkingToSittingController();
		}
		private void PHParentMom_WalkingToStanding()
		{
			PheromosaParentMomWalkingToStanding.PHParentMom_WalkingToStandingController();
		}
	}
}