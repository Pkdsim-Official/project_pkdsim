using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.converteranimations.IdleTo
{
	public class MEOWParentMom_IdleTo : MonoBehaviour 
	{
		private MEOWParentMom_IdleToRun MeowscaradaIdleToRun;
		private MEOWParentMom_IdleToWalk MeowscaradaIdleToWalk;

		public void MEOWParentMom_IdleToController()
		{
			Load_MEOWParentMom_IdleToRun();
			Load_MEOWParentMom_IdleToWalk();
		}
		private void Load_MEOWParentMom_IdleToRun()
		{
			MeowscaradaIdleToRun.MEOWParentMom_IdleToRunController();
		}
		private void Load_MEOWParentMom_IdleToWalk()
		{
			MeowscaradaIdleToWalk.MEOWParentMom_IdleToWalkController();
		}
	}
}