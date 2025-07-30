using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.idlebaseanimation
{
	public class BeedrillParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private BEParentDad_IdleStanding BeedrillParentDadIdlestanding;
		
		private BEParentDad_IdleSitting BeedrillParentDadIdlesitting;
		
		public void	BEParentDad_IdleAnimatorController()
		{
			BEParentDad_IdleStandingAnimatorController();
			BEParentDad_IdleSittingAnimatorController();
		}
		private void BEParentDad_IdleStandingAnimatorController()
		{
			BeedrillParentDadIdlestanding.BEParentDad_IdleStandingController();
		}
		private void BEParentDad_IdleSittingAnimatorController()
		{
			BeedrillParentDadIdlesitting.BEParentDad_IdleSittingController();
		}
	}
}