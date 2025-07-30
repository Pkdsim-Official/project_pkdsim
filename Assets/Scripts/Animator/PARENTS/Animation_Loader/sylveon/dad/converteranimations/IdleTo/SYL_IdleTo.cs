using project_pkdsim.ANIMATOR.Parents.Sylveon.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Sylveon.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Sylveon.Dad.converteranimations.IdleTo
{
	public class SYLParentDad_IdleTo : MonoBehaviour 
	{
		private SYLParentDad_IdleToRun Sylveon_IdleToRun;
		private SYLParentDad_IdleToWalk Sylveon_IdleToWalk;
		public void SYLParentDad_IdleToController()
		{
			Load_SYLParentDad_idleToRun();
			Load_SYLParentDad_idleToWalk();
		}
		private void Load_SYLParentDad_idleToRun()
		{
			Sylveon_IdleToRun.SYLParentDad_IdleToRunController();
		}
		private void Load_SYLParentDad_idleToWalk()
		{
			Sylveon_IdleToWalk.SYLParentDad_idleToWalkController();
		}
	}
}