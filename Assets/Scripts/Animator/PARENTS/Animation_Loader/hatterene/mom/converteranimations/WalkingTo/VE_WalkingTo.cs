using project_pkdsim.ANIMATOR.Parents.Hatterene.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.ANIMATOR.Parents.Hatterene.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Hatterene.Mom.converteranimations.WalkingTo
{
		public class HATParentMom_WalkingTo : MonoBehaviour 
	{
		private HATParentMom_WalkingToSitting HattereneParentMomWalkingToSitting;
		private HATParentMom_WalkingToStanding HattereneParentMomWalkingToStanding;
		public void HATParentMom_WalkingToController()
		{
			HATParentMom_WalkingToStartWalking();
			HATParentMom_WalkingToStanding();
		}
		private void HATParentMom_WalkingToStartWalking()
		{
			HattereneParentMomWalkingToSitting.HATParentMom_WalkingToSittingController();
		}
		private void HATParentMom_WalkingToStanding()
		{
			HattereneParentMomWalkingToStanding.HATParentMom_WalkingToStandingController();
		}
	}
}