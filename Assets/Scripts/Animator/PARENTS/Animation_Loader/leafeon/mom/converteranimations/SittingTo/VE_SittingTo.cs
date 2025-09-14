using project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.converteranimations.SittingTo
{
	public class LEParentMom_SittingTo : MonoBehaviour 
	{
		private LEParentMom_SittingToStartWalking LeafeonParentMomSittingToStartWalking;
		private LEParentMom_SittingToStanding LeafeonParentMomSittingToStanding;
		public void LEParentMom_SittingToController()
		{
			LEParentMom_SittingToStartWalking();
			LEParentMom_SittingToStanding();
		}
		private void LEParentMom_SittingToStartWalking()
		{
			LeafeonParentMomSittingToStartWalking.LEParentMom_SittingToStartWalkingController();
		}
		private void LEParentMom_SittingToStanding()
		{
			LeafeonParentMomSittingToStanding.LEParentMom_SittingToStandingController();
		}

	}
}