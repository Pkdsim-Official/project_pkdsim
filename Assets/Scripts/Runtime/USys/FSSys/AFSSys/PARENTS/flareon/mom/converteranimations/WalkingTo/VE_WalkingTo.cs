using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.converteranimations.WalkingTo
{
		public class FLParentMom_WalkingTo : MonoBehaviour 
	{
		private FLParentMom_WalkingToSitting FlareonParentMomWalkingToSitting;
		private FLParentMom_WalkingToStanding FlareonParentMomWalkingToStanding;
		public void FLParentMom_WalkingToController()
		{
			FLParentMom_WalkingToStartWalking();
			FLParentMom_WalkingToStanding();
		}
		private void FLParentMom_WalkingToStartWalking()
		{
			FlareonParentMomWalkingToSitting.FLParentMom_WalkingToSittingController();
		}
		private void FLParentMom_WalkingToStanding()
		{
			FlareonParentMomWalkingToStanding.FLParentMom_WalkingToStandingController();
		}
	}
}