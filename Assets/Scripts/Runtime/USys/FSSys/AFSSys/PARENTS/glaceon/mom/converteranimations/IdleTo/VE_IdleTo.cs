using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.converteranimations.IdleTo
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