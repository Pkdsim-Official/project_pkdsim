using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.converteranimations.WalkingTo
{
	public class DRParentDad_WalkingTo : MonoBehaviour 
	{
		private DRParentDad_WalkingToSitting DragapultWalkingToSitting;
		private DRParentDad_WalkingToStanding DragapultWalkingToStanding;
		public void DRParentDad_WalkingToController()
		{
			DRParentDad_WalkingToStartWalking();
			DRParentDad_WalkingToStanding();
		}
		private void DRParentDad_WalkingToStartWalking()
		{
			DragapultWalkingToSitting.DRParentDad_WalkingToSittingController();
		}
		private void DRParentDad_WalkingToStanding()
		{
			DragapultWalkingToStanding.DRParentDad_WalkingToStandingController();
		}
	}
}
