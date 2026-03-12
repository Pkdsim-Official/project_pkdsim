using Project_Pkdsim.ANIMATOR.Parents.Blaziken.Mom.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Parents.Blaziken.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Blaziken.Mom.converteranimations.SittingTo
{
	public class BLParentMom_SittingTo : MonoBehaviour 
	{
		private BLParentMom_SittingToStartWalking BlazikenParentMomSittingToStartWalking;
		private BLParentMom_SittingToStanding BlazikenParentMomSittingToStanding;
		public void BLParentMom_SittingToController()
		{
			BLParentMom_SittingToStartWalking();
			BLParentMom_SittingToStanding();
		}
		private void BLParentMom_SittingToStartWalking()
		{
			BlazikenParentMomSittingToStartWalking.BLParentMom_SittingToStartWalkingController();
		}
		private void BLParentMom_SittingToStanding()
		{
			BlazikenParentMomSittingToStanding.BLParentMom_SittingToStandingController();
		}

	}
}