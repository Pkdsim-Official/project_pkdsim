using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo
{
		public class VEParentMom_WalkingTo : MonoBehaviour 
	{
		private VEParentMom_WalkingToSitting BlazikenParentMomWalkingToSitting;
		private VEParentMom_WalkingToStanding BlazikenParentMomWalkingToStanding;
		public void VEParentMom_WalkingToController()
		{
			VEParentMom_WalkingToStartWalking();
			VEParentMom_WalkingToStanding();
		}
		private void VEParentMom_WalkingToStartWalking()
		{
			BlazikenParentMomWalkingToSitting.VEParentMom_WalkingToSittingController();
		}
		private void VEParentMom_WalkingToStanding()
		{
			BlazikenParentMomWalkingToStanding.VEParentMom_WalkingToStandingController();
		}
	}
}