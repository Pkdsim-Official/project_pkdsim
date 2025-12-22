using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.converteranimations.IdleTo
{
	public class BEParentDad_IdleTo : MonoBehaviour 
	{
		private BEParentDad_IdleToRun BeedrillParentDadIdleToRun;
		private BEParentDad_IdleToWalk BeedrillParentDadIdleToWalk;

		public void BEParentDad_IdleToController()
		{
			Load_BEParentDad_idleToRun();
			Load_BEParentDad_idleToWalk();
		}
		private void Load_BEParentDad_idleToRun()
		{
			BeedrillParentDadIdleToRun.BEParentDad_IdleToRunController();
		}
		private void Load_BEParentDad_idleToWalk()
		{
			BeedrillParentDadIdleToWalk.BEParentDad_IdleToWalkController();
		}
	}
}