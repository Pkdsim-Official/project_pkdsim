using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.converteranimations.WalkingTo
{
	public class DRParentMom_WalkingTo : MonoBehaviour 
	{
		private DRParentMom_WalkingToSitting DragapultWalkingToSitting;
		private DRParentMom_WalkingToStanding DragapultWalkingToStanding;
		public void DRParentMom_WalkingToController()
		{
			DRParentMom_WalkingToStartWalking();
			DRParentMom_WalkingToStanding();
		}
		private void DRParentMom_WalkingToStartWalking()
		{
			DragapultWalkingToSitting.DRParentMom_WalkingToSittingController();
		}
		private void DRParentMom_WalkingToStanding()
		{
			DragapultWalkingToStanding.DRParentMom_WalkingToStandingController();
		}
	}
}
