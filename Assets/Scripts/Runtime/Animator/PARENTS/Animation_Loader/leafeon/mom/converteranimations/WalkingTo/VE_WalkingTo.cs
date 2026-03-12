using Project_Pkdsim.ANIMATOR.Parents.Leafeon.Mom.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Parents.Leafeon.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Leafeon.Mom.converteranimations.WalkingTo
{
		public class LEParentMom_WalkingTo : MonoBehaviour 
	{
		private LEParentMom_WalkingToSitting LopunnyParentMomWalkingToSitting;
		private LEParentMom_WalkingToStanding LopunnyParentMomWalkingToStanding;
		public void LEParentMom_WalkingToController()
		{
			LEParentMom_WalkingToStartWalking();
			LEParentMom_WalkingToStanding();
		}
		private void LEParentMom_WalkingToStartWalking()
		{
			LopunnyParentMomWalkingToSitting.LEParentMom_WalkingToSittingController();
		}
		private void LEParentMom_WalkingToStanding()
		{
			LopunnyParentMomWalkingToStanding.LEParentMom_WalkingToStandingController();
		}
	}
}