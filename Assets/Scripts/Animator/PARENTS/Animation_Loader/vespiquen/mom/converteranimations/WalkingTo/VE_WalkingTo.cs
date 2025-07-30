using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo
{
		public class VEParentMom_WalkingTo : MonoBehaviour 
	{
		private VEParentMom_WalkingToSitting VespiquenParentMomWalkingToSitting;
		private VEParentMom_WalkingToStanding VespiquenParentMomWalkingToStanding;
		public void VEParentMom_WalkingToController()
		{
			VEParentMom_WalkingToStartWalking();
			VEParentMom_WalkingToStanding();
		}
		private void VEParentMom_WalkingToStartWalking()
		{
			VespiquenParentMomWalkingToSitting.VEParentMom_WalkingToSittingController();
		}
		private void VEParentMom_WalkingToStanding()
		{
			VespiquenParentMomWalkingToStanding.VEParentMom_WalkingToStandingController();
		}
	}
}