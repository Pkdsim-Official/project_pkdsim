using project_pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Delphox.Mom.converteranimations.WalkingTo
{
		public class DLParentMom_WalkingTo : MonoBehaviour 
	{
		private DLParentMom_WalkingToSitting DelphoxParentMomWalkingToSitting;
		private DLParentMom_WalkingToStanding DelphoxParentMomWalkingToStanding;
		public void DLParentMom_WalkingToController()
		{
			DLParentMom_WalkingToStartWalking();
			DLParentMom_WalkingToStanding();
		}
		private void DLParentMom_WalkingToStartWalking()
		{
			DelphoxParentMomWalkingToSitting.DLParentMom_WalkingToSittingController();
		}
		private void DLParentMom_WalkingToStanding()
		{
			DelphoxParentMomWalkingToStanding.DLParentMom_WalkingToStandingController();
		}
	}
}