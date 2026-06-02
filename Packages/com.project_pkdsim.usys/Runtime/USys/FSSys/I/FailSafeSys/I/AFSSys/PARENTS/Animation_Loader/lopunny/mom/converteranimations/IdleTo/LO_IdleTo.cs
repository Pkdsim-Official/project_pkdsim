using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.IdleTo
{
	public class LOParentMom_IdleTo : MonoBehaviour 
	{
		private LOParentMom_IdleToRun LopunnyIdleToRun;
		private LOParentMom_IdleToWalk LopunnyIdleToWalk;
		public void LOParentMom_IdleToController()
		{
			Load_LOParentMom_idleToRun();
			Load_LOParentMom_idleToWalk();
		}
		private void Load_LOParentMom_idleToRun()
		{
			LopunnyIdleToRun.LOParentMom_IdleToRunController();
		}
		private void Load_LOParentMom_idleToWalk()
		{
			LopunnyIdleToWalk.LOParentMom_IdleToWalkController();
		}
	}
}