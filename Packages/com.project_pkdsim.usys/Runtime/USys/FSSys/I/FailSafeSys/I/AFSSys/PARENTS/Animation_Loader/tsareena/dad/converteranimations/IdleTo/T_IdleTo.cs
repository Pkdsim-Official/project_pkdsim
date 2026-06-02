using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Dad.converteranimations.IdleTo
{
	public class TParentDad_IdleTo : MonoBehaviour 
	{
		private TParentDad_IdleToRun TsareenaIdleToRun;
		private TParentDad_IdleToWalk TsareenaIdleToWalk;
		public void TParentDad_IdleToController()
		{
			Load_TidleToRun();
			Load_TidleToWalk();
		}
		private void Load_TidleToRun()
		{
			TsareenaIdleToRun.TParentDad_IdleToRunController();
		}
		private void Load_TidleToWalk()
		{
			TsareenaIdleToWalk.TParentDad_IdleToWalkController();
		}
	}
}