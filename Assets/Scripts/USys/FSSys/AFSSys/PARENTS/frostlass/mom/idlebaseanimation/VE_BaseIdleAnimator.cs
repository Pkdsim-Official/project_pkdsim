using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Mom.idlebaseanimation
{
	public class FrostlassParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private FRParentMom_IdleStanding FRParentMom_Idlestanding;
		
		private FRParentMom_IdleSitting FRParentMom_Idlesitting;
		
		public void	FRParentMom_IdleAnimatorController()
		{
			FRParentMom_IdleStandingAnimatorController();
			FRParentMom_IdleSittingAnimatorController();
		}
		private void FRParentMom_IdleStandingAnimatorController()
		{
			FRParentMom_Idlestanding.FRParentMom_IdleStandingController();
		}
		private void FRParentMom_IdleSittingAnimatorController()
		{
			FRParentMom_Idlesitting.FRParentMom_IdleSittingController();
		}
	}
}