using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.converteranimations.IdleTo
{
	public class BEParentMom_IdleTo : MonoBehaviour 
	{
		private BEParentMom_IdleToRun BeedrillParentMomIdleToRun;
		private BEParentMom_IdleToWalk BeedrillParentMomIdleToWalk;

		public void BEParentMom_IdleToController()
		{
			Load_BEParentMom_idleToRun();
			Load_BEParentMom_idleToWalk();
		}
		private void Load_BEParentMom_idleToRun()
		{
			BeedrillParentMomIdleToRun.BEParentMom_IdleToRunController();
		}
		private void Load_BEParentMom_idleToWalk()
		{
			BeedrillParentMomIdleToWalk.BEParentMom_IdleToWalkController();
		}
	}
}