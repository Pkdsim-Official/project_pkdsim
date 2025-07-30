using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.converteranimations.WalkingTo
{
		public class UMParentMom_WalkingTo : MonoBehaviour 
	{
		private UMParentMom_WalkingToSitting UmbreonParentMomWalkingToSitting;
		private UMParentMom_WalkingToStanding UmbreonParentMomWalkingToStanding;
		public void UMParentMom_WalkingToController()
		{
			UMParentMom_WalkingToStartWalking();
			UMParentMom_WalkingToStanding();
		}
		private void UMParentMom_WalkingToStartWalking()
		{
			UmbreonParentMomWalkingToSitting.UMParentMom_WalkingToSittingController();
		}
		private void UMParentMom_WalkingToStanding()
		{
			UmbreonParentMomWalkingToStanding.UMParentMom_WalkingToStandingController();
		}
	}
}