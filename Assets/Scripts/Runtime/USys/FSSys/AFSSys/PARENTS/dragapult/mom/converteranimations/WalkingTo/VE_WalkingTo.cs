using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.converteranimations.WalkingTo.WalkingToSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.converteranimations.WalkingTo
{
		public class DRParentMom_WalkingTo : MonoBehaviour 
	{
		private DRParentMom_WalkingToSitting DragapultParentMomWalkingToSitting;
		private DRParentMom_WalkingToStanding DragapultParentMomWalkingToStanding;
		public void DRParentMom_WalkingToController()
		{
			DRParentMom_WalkingToStartWalking();
			DRParentMom_WalkingToStanding();
		}
		private void DRParentMom_WalkingToStartWalking()
		{
			DragapultParentMomWalkingToSitting.DRParentMom_WalkingToSittingController();
		}
		private void DRParentMom_WalkingToStanding()
		{
			DragapultParentMomWalkingToStanding.DRParentMom_WalkingToStandingController();
		}
	}
}