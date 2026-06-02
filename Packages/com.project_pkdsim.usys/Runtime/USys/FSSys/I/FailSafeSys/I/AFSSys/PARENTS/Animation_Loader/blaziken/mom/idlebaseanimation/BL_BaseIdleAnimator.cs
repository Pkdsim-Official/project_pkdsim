using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.Mom.idlebaseanimation
{
	public class BlazikenParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private BL_IdleStanding BL_Idlestanding;
		
		private BL_IdleSitting BL_Idlesitting;
		
		public void	BL_IdleAnimatorController()
		{
			BL_IdleStandingAnimatorController();
			BL_IdleSittingAnimatorController();
		}
		private void BL_IdleStandingAnimatorController()
		{
			BL_Idlestanding.BL_IdleStandingController();
		}
		private void BL_IdleSittingAnimatorController()
		{
			BL_Idlesitting.BL_IdleSittingController();
		}
	}
}