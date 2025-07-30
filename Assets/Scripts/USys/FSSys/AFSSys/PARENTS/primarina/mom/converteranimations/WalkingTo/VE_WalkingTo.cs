using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.converteranimations.WalkingTo
{
		public class PRParentMom_WalkingTo : MonoBehaviour 
	{
		private PRParentMom_WalkingToSitting PrimarinaParentMomWalkingToSitting;
		private PRParentMom_WalkingToStanding PrimarinaParentMomWalkingToStanding;
		public void PRParentMom_WalkingToController()
		{
			PRParentMom_WalkingToStartWalking();
			PRParentMom_WalkingToStanding();
		}
		private void PRParentMom_WalkingToStartWalking()
		{
			PrimarinaParentMomWalkingToSitting.PRParentMom_WalkingToSittingController();
		}
		private void PRParentMom_WalkingToStanding()
		{
			PrimarinaParentMomWalkingToStanding.PRParentMom_WalkingToStandingController();
		}
	}
}