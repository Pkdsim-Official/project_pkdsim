using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.WalkingTo
{
		public class VEParentMom_WalkingTo : MonoBehaviour 
	{
		private VEParentMom_WalkingToSitting HattereneParentMomWalkingToSitting;
		private VEParentMom_WalkingToStanding HattereneParentMomWalkingToStanding;
		public void VEParentMom_WalkingToController()
		{
			VEParentMom_WalkingToStartWalking();
			VEParentMom_WalkingToStanding();
		}
		private void VEParentMom_WalkingToStartWalking()
		{
			HattereneParentMomWalkingToSitting.VEParentMom_WalkingToSittingController();
		}
		private void VEParentMom_WalkingToStanding()
		{
			HattereneParentMomWalkingToStanding.VEParentMom_WalkingToStandingController();
		}
	}
}