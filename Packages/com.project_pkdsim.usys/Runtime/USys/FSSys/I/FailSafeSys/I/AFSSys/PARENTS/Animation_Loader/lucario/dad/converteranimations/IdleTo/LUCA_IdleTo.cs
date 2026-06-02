using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.converteranimations.IdleTo
{
	public class LUCAParentDad_IdleTo : MonoBehaviour 
	{
		private LUCAParentDad_IdleToRun LucarioIdleToRun;
		private LUCAParentDad_IdleToWalk LucarioIdleToWalk;

		public void LUCAParentDad_IdleToController()
		{
			Load_LUCAParentDad_idleToRun();
			Load_LUCAParentDad_idleToWalk();
		}
		private void Load_LUCAParentDad_idleToRun()
		{
			LucarioIdleToRun.LUCAParentDad_IdleToRunController();
		}
		private void Load_LUCAParentDad_idleToWalk()
		{
			LucarioIdleToWalk.LUCAParentDad_IdleToWalkController();
		}
	}
}