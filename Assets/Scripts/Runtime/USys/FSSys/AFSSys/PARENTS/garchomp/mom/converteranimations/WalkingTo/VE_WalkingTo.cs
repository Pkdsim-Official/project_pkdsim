using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.WalkingTo
{
		public class GARCParentMom_WalkingTo : MonoBehaviour 
	{
		private GARCParentMom_WalkingToSitting GarchompParentMomWalkingToSitting;
		private GARCParentMom_WalkingToStanding GarchompParentMomWalkingToStanding;
		public void GARCParentMom_WalkingToController()
		{
			GARCParentMom_WalkingToStartWalking();
			GARCParentMom_WalkingToStanding();
		}
		private void GARCParentMom_WalkingToStartWalking()
		{
			GarchompParentMomWalkingToSitting.GARCParentMom_WalkingToSittingController();
		}
		private void GARCParentMom_WalkingToStanding()
		{
			GarchompParentMomWalkingToStanding.GARCParentMom_WalkingToStandingController();
		}
	}
}