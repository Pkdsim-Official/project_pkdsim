using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.SittingTo
{
	public class VEParentMom_SittingTo : MonoBehaviour 
	{
		private VEParentMom_SittingToStartWalking PheromosaParentMomSittingToStartWalking;
		private VEParentMom_SittingToStanding PheromosaParentMomSittingToStanding;
		public void VEParentMom_SittingToController()
		{
			VEParentMom_SittingToStartWalking();
			VEParentMom_SittingToStanding();
		}
		private void VEParentMom_SittingToStartWalking()
		{
			PheromosaParentMomSittingToStartWalking.VEParentMom_SittingToStartWalkingController();
		}
		private void VEParentMom_SittingToStanding()
		{
			PheromosaParentMomSittingToStanding.VEParentMom_SittingToStandingController();
		}

	}
}