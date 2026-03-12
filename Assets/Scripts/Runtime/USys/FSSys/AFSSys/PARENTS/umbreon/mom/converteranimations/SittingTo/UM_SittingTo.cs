using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.converteranimations.SittingTo.SittingToStartWalking;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.converteranimations.SittingTo
{
	public class UMParentMom_SittingTo : MonoBehaviour 
	{
		private UMParentMom_SittingToStartWalking UmbreonParentMomSittingToStartWalking;
		private UMParentMom_SittingToStanding UmbreonParentMomSittingToStanding;
		public void UMParentMom_SittingToController()
		{
			UMParentMom_SittingToStartWalking();
			UMParentMom_SittingToStanding();
		}
		private void UMParentMom_SittingToStartWalking()
		{
			UmbreonParentMomSittingToStartWalking.UMParentMom_SittingToStartWalkingController();
		}
		private void UMParentMom_SittingToStanding()
		{
			UmbreonParentMomSittingToStanding.UMParentMom_SittingToStandingController();
		}

	}
}