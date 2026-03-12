using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.converteranimations.SittingTo
{
	public class DRParentMom_SittingTo : MonoBehaviour 
	{
		private DRParentMom_SittingToStartWalking DragapultParentMomSittingToStartWalking;
		private DRParentMom_SittingToStanding DragapultParentMomSittingToStanding;
		public void DRParentMom_SittingToController()
		{
			DRParentMom_SittingToStartWalking();
			DRParentMom_SittingToStanding();
		}
		private void DRParentMom_SittingToStartWalking()
		{
			DragapultParentMomSittingToStartWalking.DRParentMom_SittingToStartWalkingController();
		}
		private void DRParentMom_SittingToStanding()
		{
			DragapultParentMomSittingToStanding.DRParentMom_SittingToStandingController();
		}

	}
}