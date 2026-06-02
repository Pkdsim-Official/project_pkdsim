using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.converteranimations.SittingTo
{
	public class DRParentMom_SittingTo : MonoBehaviour 
	{
		private DRParentMom_SittingToStartWalking DragapultsittingToStartWalking;
		private DRParentMom_SittingToStanding DragapultsittingToStanding;
		public void DRParentMom_SittingToController()
		{
			DRParentMom_SittingToStartWalking();
			DRParentMom_SittingToStanding();
		}
		private void DRParentMom_SittingToStartWalking()
		{
			DragapultsittingToStartWalking.DRParentMom_SittingToStartWalkingController();
		}
		private void DRParentMom_SittingToStanding()
		{
			DragapultsittingToStanding.DRParentMom_SittingToStandingController();
		}
	}
}