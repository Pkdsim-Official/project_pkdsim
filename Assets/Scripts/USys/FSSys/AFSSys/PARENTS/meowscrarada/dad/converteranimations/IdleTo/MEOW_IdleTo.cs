using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.converteranimations.IdleTo
{
	public class MEOWIdleTo : MonoBehaviour 
	{
		private MEOWIdleToRun MeowscaradaIdleToRun;
		private MEOWIdleToWalk MeowscaradaIdleToWalk;

		public void MEOW_IdleToController()
		{
			Load_MEOWIdleToRun();
			Load_MEOWIdleToWalk();
		}
		private void Load_MEOWIdleToRun()
		{
			MeowscaradaIdleToRun.MEOWIdleToRunController();
		}
		private void Load_MEOWIdleToWalk()
		{
			MeowscaradaIdleToWalk.MEOWIdleToWalkController();
		}
	}
}