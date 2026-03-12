using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.converteranimations.IdleTo
{
	public class GLParentDad_IdleTo : MonoBehaviour 
	{
		private GLParentDad_IdleToRun GlaceonIdleToRun;
		private GLParentDad_IdleToWalk GlaceonIdleToWalk;
		public void GLParentDad_IdleToController()
		{
			Load_GLParentDad_idleToRun();
			Load_GLParentDad_idleToWalk();
		}
		private void Load_GLParentDad_idleToRun()
		{
			GlaceonIdleToRun.GLParentDad_IdleToRunController();
		}
		private void Load_GLParentDad_idleToWalk()
		{
			GlaceonIdleToWalk.GLParentDad_IdleToWalkController();
		}
	}
}