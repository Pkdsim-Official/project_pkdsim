using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.converteranimations.WalkingTo
{
		public class CParentMom_WalkingTo : MonoBehaviour 
	{
		private CParentMom_WalkingToSitting CinderaceParentMomWalkingToSitting;
		private CParentMom_WalkingToStanding CinderaceParentMomWalkingToStanding;
		public void CParentMom_WalkingToController()
		{
			CParentMom_WalkingToStartWalking();
			CParentMom_WalkingToStanding();
		}
		private void CParentMom_WalkingToStartWalking()
		{
			CinderaceParentMomWalkingToSitting.CParentMom_WalkingToSittingController();
		}
		private void CParentMom_WalkingToStanding()
		{
			CinderaceParentMomWalkingToStanding.CParentMom_WalkingToStandingController();
		}
	}
}