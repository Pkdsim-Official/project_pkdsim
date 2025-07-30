using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.converteranimations.IdleTo
{
	public class NOIParentMom_IdleTo : MonoBehaviour 
	{
		private NOIParentMom_IdleToRun NoivernParentMomIdleToRun;
		private NOIParentMom_IdleToWalk NoivernParentMomIdleToWalk;

		public void NOIParentMom_IdleToController()
		{
			Load_NOIParentMom_idleToRun();
			Load_NOIParentMom_idleToWalk();
		}
		private void Load_NOIParentMom_idleToRun()
		{
			NoivernParentMomIdleToRun.NOIParentMom_IdleToRunController();
		}
		private void Load_NOIParentMom_idleToWalk()
		{
			NoivernParentMomIdleToWalk.NOIParentMom_IdleToWalkController();
		}
	}
}