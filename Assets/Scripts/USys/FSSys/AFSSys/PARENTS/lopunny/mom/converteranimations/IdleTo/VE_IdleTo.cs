using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.converteranimations.IdleTo
{
	public class LOParentMom_IdleTo : MonoBehaviour 
	{
		private LOParentMom_IdleToRun LopunnyParentMomIdleToRun;
		private LOParentMom_IdleToWalk LopunnyParentMomIdleToWalk;

		public void LOParentMom_IdleToController()
		{
			Load_LOParentMom_idleToRun();
			Load_LOParentMom_idleToWalk();
		}
		private void Load_LOParentMom_idleToRun()
		{
			LopunnyParentMomIdleToRun.LOParentMom_IdleToRunController();
		}
		private void Load_LOParentMom_idleToWalk()
		{
			LopunnyParentMomIdleToWalk.LOParentMom_IdleToWalkController();
		}
	}
}