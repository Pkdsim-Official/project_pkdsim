using project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.SittingTo
{
	public class VPParentMom_SittingTo : MonoBehaviour 
	{
		private VPParentMom_SittingToStartWalking VaporeonParentMomSittingToStartWalking;
		private VPParentMom_SittingToStanding VaporeonParentMomSittingToStanding;
		public void VPParentMom_SittingToController()
		{
			VPParentMom_SittingToStartWalking();
			VPParentMom_SittingToStanding();
		}
		private void VPParentMom_SittingToStartWalking()
		{
			VaporeonParentMomSittingToStartWalking.VPParentMom_SittingToStartWalkingController();
		}
		private void VPParentMom_SittingToStanding()
		{
			VaporeonParentMomSittingToStanding.VPParentMom_SittingToStandingController();
		}

	}
}