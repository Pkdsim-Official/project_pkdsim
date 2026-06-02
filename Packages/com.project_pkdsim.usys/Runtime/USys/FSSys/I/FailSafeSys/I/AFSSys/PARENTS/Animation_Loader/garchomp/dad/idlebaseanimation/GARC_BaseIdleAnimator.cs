using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Dad.idlebaseanimation
{
	public class GarchompParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private GARCParentDad_IdleStanding Garchompidlestanding;
		
		private GARCParentDad_IdleSitting Garchompidlesitting;
		
		public void	GARCParentDad_IdleAnimatorController()
		{
			GARCParentDad_IdleStandingAnimatorController();
			GARCParentDad_IdleSittingAnimatorController();
		}
		private void GARCParentDad_IdleStandingAnimatorController()
		{
			Garchompidlestanding.GARCParentDad_IdleStandingController();
		}
		private void GARCParentDad_IdleSittingAnimatorController()
		{
			Garchompidlesitting.GARCParentDad_IdleSittingController();
		}
	}
}