using Project_Pkdsim.ANIMATOR.Parents.Braixen.Mom.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.ANIMATOR.Parents.Braixen.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Braixen.Mom.converteranimations.WalkingTo
{
		public class BRParentMom_WalkingTo : MonoBehaviour 
	{
		private BRParentMom_WalkingToSitting BraixenParentMomWalkingToSitting;
		private BRParentMom_WalkingToStanding BraixenParentMomWalkingToStanding;
		public void BRParentMom_WalkingToController()
		{
			BRParentMom_WalkingToStartWalking();
			BRParentMom_WalkingToStanding();
		}
		private void BRParentMom_WalkingToStartWalking()
		{
			BraixenParentMomWalkingToSitting.BRParentMom_WalkingToSittingController();
		}
		private void BRParentMom_WalkingToStanding()
		{
			BraixenParentMomWalkingToStanding.BRParentMom_WalkingToStandingController();
		}
	}
}