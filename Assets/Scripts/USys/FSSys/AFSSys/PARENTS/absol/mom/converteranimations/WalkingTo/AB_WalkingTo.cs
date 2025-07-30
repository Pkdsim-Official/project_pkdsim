using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.converteranimations.WalkingTo
{
		public class ABParentMom_WalkingTo : MonoBehaviour 
	{
		private ABParentMom_WalkingToSitting AbsolParentMomWalkingToSitting;
		private ABParentMom_WalkingToStanding AbsolParentMomWalkingToStanding;
		public void ABParentMom_WalkingToController()
		{
			ABParentMom_WalkingToStartWalking();
			ABParentMom_WalkingToStanding();
		}
		private void ABParentMom_WalkingToStartWalking()
		{
			AbsolParentMomWalkingToSitting.ABParentMom_WalkingToSittingController();
		}
		private void ABParentMom_WalkingToStanding()
		{
			AbsolParentMomWalkingToStanding.ABParentMom_WalkingToStandingController();
		}
	}
}