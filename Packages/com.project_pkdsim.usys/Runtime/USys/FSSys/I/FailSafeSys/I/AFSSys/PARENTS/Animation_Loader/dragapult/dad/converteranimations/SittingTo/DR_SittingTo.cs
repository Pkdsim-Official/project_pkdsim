using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.converteranimations.SittingTo
{
	public class DRParentDad_SittingTo : MonoBehaviour 
	{
		private DRParentDad_SittingToStartWalking DragapultsittingToStartWalking;
		private DRParentDad_SittingToStanding DragapultsittingToStanding;
		public void DRParentDad_SittingToController()
		{
			DRParentDad_SittingToStartWalking();
			DRParentDad_SittingToStanding();
		}
		private void DRParentDad_SittingToStartWalking()
		{
			DragapultsittingToStartWalking.DRParentDad_SittingToStartWalkingController();
		}
		private void DRParentDad_SittingToStanding()
		{
			DragapultsittingToStanding.DRParentDad_SittingToStandingController();
		}
	}
}