using project_pkdsim.ANIMATOR.Parents.Braixen.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Braixen.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Braixen.Mom.converteranimations.SittingTo
{
	public class BRParentMom_SittingTo : MonoBehaviour 
	{
		private BRParentMom_SittingToStartWalking BraixenParentMomSittingToStartWalking;
		private BRParentMom_SittingToStanding BraixenParentMomSittingToStanding;
		public void BRParentMom_SittingToController()
		{
			BRParentMom_SittingToStartWalking();
			BRParentMom_SittingToStanding();
		}
		private void BRParentMom_SittingToStartWalking()
		{
			BraixenParentMomSittingToStartWalking.BRParentMom_SittingToStartWalkingController();
		}
		private void BRParentMom_SittingToStanding()
		{
			BraixenParentMomSittingToStanding.BRParentMom_SittingToStandingController();
		}

	}
}