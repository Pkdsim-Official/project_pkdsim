using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.SittingTo
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