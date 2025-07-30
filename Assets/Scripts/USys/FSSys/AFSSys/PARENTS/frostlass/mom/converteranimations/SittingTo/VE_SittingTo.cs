using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Mom.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Mom.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Mom.converteranimations.SittingTo
{
	public class FRParentMom_SittingTo : MonoBehaviour 
	{
		private FRParentMom_SittingToStartWalking FrostlassParentMomSittingToStartWalking;
		private FRParentMom_SittingToStanding FrostlassParentMomSittingToStanding;
		public void FRParentMom_SittingToController()
		{
			FRParentMom_SittingToStartWalking();
			FRParentMom_SittingToStanding();
		}
		private void FRParentMom_SittingToStartWalking()
		{
			FrostlassParentMomSittingToStartWalking.FRParentMom_SittingToStartWalkingController();
		}
		private void FRParentMom_SittingToStanding()
		{
			FrostlassParentMomSittingToStanding.FRParentMom_SittingToStandingController();
		}

	}
}