using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.converteranimations.IdleTo
{
	public class LOParentDad_IdleTo : MonoBehaviour 
	{
		private LOParentDad_IdleToRun LopunnyIdleToRun;
		private LOParentDad_IdleToWalk LopunnyIdleToWalk;
		public void LOParentDad_IdleToController()
		{
			Load_LOParentDad_idleToRun();
			Load_LOParentDad_idleToWalk();
		}
		private void Load_LOParentDad_idleToRun()
		{
			LopunnyIdleToRun.LOParentDad_IdleToRunController();
		}
		private void Load_LOParentDad_idleToWalk()
		{
			LopunnyIdleToWalk.LOParentDad_IdleToWalkController();
		}
	}
}