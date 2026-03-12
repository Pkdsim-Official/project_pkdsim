using Project_Pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Flareon.Mom.converteranimations.SittingTo
{
	public class FLParentMom_SittingTo : MonoBehaviour 
	{
		private FLParentMom_SittingToStartWalking FlareonParentMomSittingToStartWalking;
		private FLParentMom_SittingToStanding FlareonParentMomSittingToStanding;
		public void FLParentMom_SittingToController()
		{
			FLParentMom_SittingToStartWalking();
			FLParentMom_SittingToStanding();
		}
		private void FLParentMom_SittingToStartWalking()
		{
			FlareonParentMomSittingToStartWalking.FLParentMom_SittingToStartWalkingController();
		}
		private void FLParentMom_SittingToStanding()
		{
			FlareonParentMomSittingToStanding.FLParentMom_SittingToStandingController();
		}

	}
}