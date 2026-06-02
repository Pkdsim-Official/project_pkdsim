using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.idlebaseanimation
{
	public class GarchompParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private GARCParentMom_IdleStanding Garchompidlestanding;
		
		private GARCParentMom_IdleSitting Garchompidlesitting;
		
		public void	GARCParentMom_IdleAnimatorController()
		{
			GARCParentMom_IdleStandingAnimatorController();
			GARCParentMom_IdleSittingAnimatorController();
		}
		private void GARCParentMom_IdleStandingAnimatorController()
		{
			Garchompidlestanding.GARCParentMom_IdleStandingController();
		}
		private void GARCParentMom_IdleSittingAnimatorController()
		{
			Garchompidlesitting.GARCParentMom_IdleSittingController();
		}
	}
}