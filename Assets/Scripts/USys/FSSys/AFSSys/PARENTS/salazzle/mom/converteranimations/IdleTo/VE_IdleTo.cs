using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations.IdleTo
{
	public class SParentMom_IdleTo : MonoBehaviour 
	{
		private SParentMom_IdleToRun SalazzleParentMomIdleToRun;
		private SParentMom_IdleToWalk SalazzleParentMomIdleToWalk;

		public void SParentMom_IdleToController()
		{
			Load_SParentMom_idleToRun();
			Load_SParentMom_idleToWalk();
		}
		private void Load_SParentMom_idleToRun()
		{
			SalazzleParentMomIdleToRun.SParentMom_IdleToRunController();
		}
		private void Load_SParentMom_idleToWalk()
		{
			SalazzleParentMomIdleToWalk.SParentMom_IdleToWalkController();
		}
	}
}