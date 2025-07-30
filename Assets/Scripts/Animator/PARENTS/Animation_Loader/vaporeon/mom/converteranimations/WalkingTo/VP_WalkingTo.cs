using project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.WalkingTo
{
		public class VPParentMom_WalkingTo : MonoBehaviour 
	{
		private VPParentMom_WalkingToSitting VaporeonParentMomWalkingToSitting;
		private VPParentMom_WalkingToStanding VaporeonParentMomWalkingToStanding;
		public void VPParentMom_WalkingToController()
		{
			VPParentMom_WalkingToStartWalking();
			VPParentMom_WalkingToStanding();
		}
		private void VPParentMom_WalkingToStartWalking()
		{
			VaporeonParentMomWalkingToSitting.VPParentMom_WalkingToSittingController();
		}
		private void VPParentMom_WalkingToStanding()
		{
			VaporeonParentMomWalkingToStanding.VPParentMom_WalkingToStandingController();
		}
	}
}