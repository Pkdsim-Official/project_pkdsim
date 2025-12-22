using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.converteranimations.IdleTo
{
	public class GLParentMom_IdleTo : MonoBehaviour 
	{
		private GLParentMom_IdleToRun GlaceonParentMomIdleToRun;
		private GLParentMom_IdleToWalk GlaceonParentMomIdleToWalk;

		public void GLParentMom_IdleToController()
		{
			Load_GLParentMom_idleToRun();
			Load_GLParentMom_idleToWalk();
		}
		private void Load_GLParentMom_idleToRun()
		{
			GlaceonParentMomIdleToRun.GLParentMom_IdleToRunController();
		}
		private void Load_GLParentMom_idleToWalk()
		{
			GlaceonParentMomIdleToWalk.GLParentMom_IdleToWalkController();
		}
	}
}