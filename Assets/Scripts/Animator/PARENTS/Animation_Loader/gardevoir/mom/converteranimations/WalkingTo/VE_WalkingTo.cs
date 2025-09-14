using project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.converteranimations.WalkingTo
{
		public class GARDParentMom_WalkingTo : MonoBehaviour 
	{
		private GARDParentMom_WalkingToSitting GardevoirParentMomWalkingToSitting;
		private GARDParentMom_WalkingToStanding GardevoirParentMomWalkingToStanding;
		public void GARDParentMom_WalkingToController()
		{
			GARDParentMom_WalkingToStartWalking();
			GARDParentMom_WalkingToStanding();
		}
		private void GARDParentMom_WalkingToStartWalking()
		{
			GardevoirParentMomWalkingToSitting.GARDParentMom_WalkingToSittingController();
		}
		private void GARDParentMom_WalkingToStanding()
		{
			GardevoirParentMomWalkingToStanding.GARDParentMom_WalkingToStandingController();
		}
	}
}