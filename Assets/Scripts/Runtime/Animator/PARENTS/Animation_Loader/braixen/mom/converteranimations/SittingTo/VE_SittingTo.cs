using Project_Pkdsim.ANIMATOR.Parents.Braixen.Mom.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Parents.Braixen.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Braixen.Mom.converteranimations.SittingTo
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