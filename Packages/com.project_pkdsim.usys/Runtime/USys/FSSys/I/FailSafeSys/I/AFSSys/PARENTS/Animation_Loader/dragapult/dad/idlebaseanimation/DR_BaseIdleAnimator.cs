using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.idlebaseanimation
{
	public class DragapultParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private DRParentDad_IdleStanding Dragapultidlestanding;
		
		private DRParentDad_IdleSitting Dragapultidlesitting;
		
		public void	DRParentDad_IdleAnimatorController()
		{
			DRParentDad_IdleStandingAnimatorController();
			DRParentDad_IdleSittingAnimatorController();
		}
		private void DRParentDad_IdleStandingAnimatorController()
		{
			Dragapultidlestanding.DRParentDad_IdleStandingController();
		}
		private void DRParentDad_IdleSittingAnimatorController()
		{
			Dragapultidlesitting.DRParentDad_IdleSittingController();
		}
	}
}