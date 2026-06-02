using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.converteranimations.IdleTo
{
	public class LUCAParentMom_IdleTo : MonoBehaviour 
	{
		private LUCAParentMom_IdleToRun LucarioIdleToRun;
		private LUCAParentMom_IdleToWalk LucarioIdleToWalk;

		public void LUCAParentMom_IdleToController()
		{
			Load_LUCAParentMom_idleToRun();
			Load_LUCAParentMom_idleToWalk();
		}
		private void Load_LUCAParentMom_idleToRun()
		{
			LucarioIdleToRun.LUCAParentMom_IdleToRunController();
		}
		private void Load_LUCAParentMom_idleToWalk()
		{
			LucarioIdleToWalk.LUCAParentMom_IdleToWalkController();
		}
	}
}