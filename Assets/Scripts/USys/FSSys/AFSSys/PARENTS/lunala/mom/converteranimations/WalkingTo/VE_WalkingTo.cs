using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.WalkingTo
{
		public class LUNAParentMom_WalkingTo : MonoBehaviour 
	{
		private LUNAParentMom_WalkingToSitting LunalaParentMomWalkingToSitting;
		private LUNAParentMom_WalkingToStanding LunalaParentMomWalkingToStanding;
		public void LUNAParentMom_WalkingToController()
		{
			LUNAParentMom_WalkingToStartWalking();
			LUNAParentMom_WalkingToStanding();
		}
		private void LUNAParentMom_WalkingToStartWalking()
		{
			LunalaParentMomWalkingToSitting.LUNAParentMom_WalkingToSittingController();
		}
		private void LUNAParentMom_WalkingToStanding()
		{
			LunalaParentMomWalkingToStanding.LUNAParentMom_WalkingToStandingController();
		}
	}
}