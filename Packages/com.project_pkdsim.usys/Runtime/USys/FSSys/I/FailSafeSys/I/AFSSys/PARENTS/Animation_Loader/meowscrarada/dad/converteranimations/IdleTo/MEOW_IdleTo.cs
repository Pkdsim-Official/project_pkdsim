using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.converteranimations.IdleTo
{
	public class MEOWParentDad_IdleTo : MonoBehaviour 
	{
		private MEOWParentDad_IdleToRun MeowscaradaIdleToRun;
		private MEOWParentDad_IdleToWalk MeowscaradaIdleToWalk;

		public void MEOWParentDad_IdleToController()
		{
			Load_MEOWParentDad_IdleToRun();
			Load_MEOWParentDad_IdleToWalk();
		}
		private void Load_MEOWParentDad_IdleToRun()
		{
			MeowscaradaIdleToRun.MEOWParentDad_IdleToRunController();
		}
		private void Load_MEOWParentDad_IdleToWalk()
		{
			MeowscaradaIdleToWalk.MEOWParentDad_IdleToWalkController();
		}
	}
}