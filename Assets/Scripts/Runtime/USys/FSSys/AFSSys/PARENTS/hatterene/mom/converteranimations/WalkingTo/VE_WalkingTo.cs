using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.converteranimations.WalkingTo
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