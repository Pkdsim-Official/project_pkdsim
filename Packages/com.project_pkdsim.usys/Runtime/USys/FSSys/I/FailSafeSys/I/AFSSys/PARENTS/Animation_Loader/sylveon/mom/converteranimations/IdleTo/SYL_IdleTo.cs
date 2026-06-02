using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.converteranimations.IdleTo
{
	public class SYLParentMom_IdleTo : MonoBehaviour 
	{
		private SYLParentMom_IdleToRun Sylveon_IdleToRun;
		private SYLParentMom_IdleToWalk Sylveon_IdleToWalk;
		public void SYLParentMom_IdleToController()
		{
			Load_SYLParentMom_idleToRun();
			Load_SYLParentMom_idleToWalk();
		}
		private void Load_SYLParentMom_idleToRun()
		{
			Sylveon_IdleToRun.SYLParentMom_IdleToRunController();
		}
		private void Load_SYLParentMom_idleToWalk()
		{
			Sylveon_IdleToWalk.SYLParentMom_idleToWalkController();
		}
	}
}