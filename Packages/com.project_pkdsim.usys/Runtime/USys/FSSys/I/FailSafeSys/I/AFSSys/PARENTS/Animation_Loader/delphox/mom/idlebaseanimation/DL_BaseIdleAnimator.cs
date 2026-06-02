using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.idlebaseanimation
{
	public class DelphoxParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private DLIdleStanding DLidlestanding;
		
		private DLIdleSitting DLidlesitting;
		
		public void	DL_IdleAnimatorController()
		{
			DLIdleStandingAnimatorController();
			DLIdleSittingAnimatorController();
		}
		private void DLIdleStandingAnimatorController()
		{
			DLidlestanding.DLIdleStandingController();
		}
		private void DLIdleSittingAnimatorController()
		{
			DLidlesitting.DLIdleSittingController();
		}
	}
}