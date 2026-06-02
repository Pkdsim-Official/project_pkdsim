using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.converteranimations.IdleTo
{
	public class TParentMom_IdleTo : MonoBehaviour 
	{
		private TParentMom_IdleToRun TsareenaIdleToRun;
		private TParentMom_IdleToWalk TsareenaIdleToWalk;
		public void TParentMom_IdleToController()
		{
			Load_TidleToRun();
			Load_TidleToWalk();
		}
		private void Load_TidleToRun()
		{
			TsareenaIdleToRun.TParentMom_IdleToRunController();
		}
		private void Load_TidleToWalk()
		{
			TsareenaIdleToWalk.TParentMom_IdleToWalkController();
		}
	}
}