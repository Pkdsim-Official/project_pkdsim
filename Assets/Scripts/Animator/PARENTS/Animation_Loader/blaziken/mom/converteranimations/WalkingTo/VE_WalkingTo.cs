using project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.converteranimations.WalkingTo
{
		public class BLParentMom_WalkingTo : MonoBehaviour 
	{
		private BLParentMom_WalkingToSitting BlazikenParentMomWalkingToSitting;
		private BLParentMom_WalkingToStanding BlazikenParentMomWalkingToStanding;
		public void BLParentMom_WalkingToController()
		{
			BLParentMom_WalkingToStartWalking();
			BLParentMom_WalkingToStanding();
		}
		private void BLParentMom_WalkingToStartWalking()
		{
			BlazikenParentMomWalkingToSitting.BLParentMom_WalkingToSittingController();
		}
		private void BLParentMom_WalkingToStanding()
		{
			BlazikenParentMomWalkingToStanding.BLParentMom_WalkingToStandingController();
		}
	}
}