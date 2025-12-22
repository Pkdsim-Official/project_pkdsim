using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.IdleTo
{
	public class MEOWParentMom_IdleTo : MonoBehaviour 
	{
		private MEOWParentMom_IdleToRun MeowscaradaParentMomIdleToRun;
		private MEOWParentMom_IdleToWalk MeowscaradaParentMomIdleToWalk;

		public void MEOWParentMom_IdleToController()
		{
			Load_MEOWParentMom_idleToRun();
			Load_MEOWParentMom_idleToWalk();
		}
		private void Load_MEOWParentMom_idleToRun()
		{
			MeowscaradaParentMomIdleToRun.MEOWParentMom_IdleToRunController();
		}
		private void Load_MEOWParentMom_idleToWalk()
		{
			MeowscaradaParentMomIdleToWalk.MEOWParentMom_IdleToWalkController();
		}
	}
}