using Project_Pkdsim.ANIMATOR.Parents.Cinderace.Mom.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Parents.Cinderace.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Cinderace.Mom.converteranimations.WalkingTo
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