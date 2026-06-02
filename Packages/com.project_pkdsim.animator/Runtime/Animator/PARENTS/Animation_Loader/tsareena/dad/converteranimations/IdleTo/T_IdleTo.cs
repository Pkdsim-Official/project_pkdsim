using project_pkdsim.ANIMATOR.Parents.Tsareena.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.Dad.converteranimations.IdleTo
{
	public class TParentDad_IdleTo : MonoBehaviour 
	{
		private TParentDad_IdleToRun TsareenaIdleToRun;
		private TParentDad_IdleToWalk TsareenaIdleToWalk;
		public void TParentDad_IdleToController()
		{
			Load_TParentDad_IdleToRun();
			Load_TParentDad_IdleToWalk();
		}
		private void Load_TParentDad_IdleToRun()
		{
			TsareenaIdleToRun.TParentDad_IdleToRunController();
		}
		private void Load_TParentDad_IdleToWalk()
		{
			TsareenaIdleToWalk.TParentDad_IdleToWalkController();
		}
	}
}