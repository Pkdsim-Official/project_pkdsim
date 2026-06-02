using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Tsareena.Mom.converteranimations.IdleTo
{
	public class TParentMom_IdleTo : MonoBehaviour 
	{
		private TParentMom_IdleToRun TsareenaParentMom_IdleToRun;
		private TParentMom_IdleToWalk TsareenaParentMom_IdleToWalk;
		public void TParentMom_IdleToController()
		{
			TParentMom_idleToRun();
			TParentMom_idleToWalk();
		}
		private void TParentMom_idleToRun()
		{
			TsareenaParentMom_IdleToRun.TParentMom_IdleToRunController();
		}
		private void TParentMom_idleToWalk()
		{
			TsareenaParentMom_IdleToWalk.TParentMom_IdleToWalkController();
		}
	}
}