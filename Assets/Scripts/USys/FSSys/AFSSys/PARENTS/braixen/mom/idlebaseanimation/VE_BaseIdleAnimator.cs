using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Braixen.Mom.idlebaseanimation
{
	public class BraixenParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private BRParentMom_IdleStanding BRParentMom_Idlestanding;
		
		private BRParentMom_IdleSitting BRParentMom_Idlesitting;
		
		public void	BRParentMom_IdleAnimatorController()
		{
			BRParentMom_IdleStandingAnimatorController();
			BRParentMom_IdleSittingAnimatorController();
		}
		private void BRParentMom_IdleStandingAnimatorController()
		{
			BRParentMom_Idlestanding.BRParentMom_IdleStandingController();
		}
		private void BRParentMom_IdleSittingAnimatorController()
		{
			BRParentMom_Idlesitting.BRParentMom_IdleSittingController();
		}
	}
}