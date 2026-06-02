using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.idlebaseanimation
{
	public class DragapultParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private DRParentMom_IdleStanding Dragapultidlestanding;
		
		private DRParentMom_IdleSitting Dragapultidlesitting;
		
		public void	DRParentMom_IdleAnimatorController()
		{
			DRParentMom_IdleStandingAnimatorController();
			DRParentMom_IdleSittingAnimatorController();
		}
		private void DRParentMom_IdleStandingAnimatorController()
		{
			Dragapultidlestanding.DRParentMom_IdleStandingController();
		}
		private void DRParentMom_IdleSittingAnimatorController()
		{
			Dragapultidlesitting.DRParentMom_IdleSittingController();
		}
	}
}