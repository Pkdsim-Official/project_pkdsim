using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.idlebaseanimation.IdleSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.idlebaseanimation
{
	public class DragapultParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private DRParentMom_IdleStanding DRParentMom_Idlestanding;
		
		private DRParentMom_IdleSitting DRParentMom_Idlesitting;
		
		public void	DRParentMom_IdleAnimatorController()
		{
			DRParentMom_IdleStandingAnimatorController();
			DRParentMom_IdleSittingAnimatorController();
		}
		private void DRParentMom_IdleStandingAnimatorController()
		{
			DRParentMom_Idlestanding.DRParentMom_IdleStandingController();
		}
		private void DRParentMom_IdleSittingAnimatorController()
		{
			DRParentMom_Idlesitting.DRParentMom_IdleSittingController();
		}
	}
}