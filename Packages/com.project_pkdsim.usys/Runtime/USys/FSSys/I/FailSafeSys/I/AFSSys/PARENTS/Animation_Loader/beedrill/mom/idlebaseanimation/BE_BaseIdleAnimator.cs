using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.idlebaseanimation
{
	public class BeedrillParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private BE_IdleStanding BeedrillIdlestanding;
		
		private BE_IdleSitting BeedrillIdlesitting;
		
		public void	BE_IdleAnimatorController()
		{
			BE_IdleStandingAnimatorController();
			BE_IdleSittingAnimatorController();
		}
		private void BE_IdleStandingAnimatorController()
		{
			BeedrillIdlestanding.BE_IdleStandingController();
		}
		private void BE_IdleSittingAnimatorController()
		{
			BeedrillIdlesitting.BE_IdleSittingController();
		}
	}
}