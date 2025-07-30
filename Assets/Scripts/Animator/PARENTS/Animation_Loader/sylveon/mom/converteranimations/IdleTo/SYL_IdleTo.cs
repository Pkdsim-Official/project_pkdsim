using project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Sylveon.Mom.converteranimations.IdleTo
{
	public class SYLParentMom_IdleTo : MonoBehaviour 
	{
		private SYLParentMom_IdleToRun SylveonParentMomIdleToRun;
		private SYLParentMom_IdleToWalk SylveonParentMomIdleToWalk;

		public void SYLParentMom_IdleToController()
		{
			Load_SYLParentMom_idleToRun();
			Load_SYLParentMom_idleToWalk();
		}
		private void Load_SYLParentMom_idleToRun()
		{
			SylveonParentMomIdleToRun.SYLParentMom_IdleToRunController();
		}
		private void Load_SYLParentMom_idleToWalk()
		{
			SylveonParentMomIdleToWalk.SYLParentMom_IdleToWalkController();
		}
	}
}