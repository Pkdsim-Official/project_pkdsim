using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.converteranimations.IdleTo
{
	public class ABParentMom_IdleTo : MonoBehaviour 
	{
		private ABParentMom_IdleToRun AbsolParentMomIdleToRun;
		private ABParentMom_IdleToWalk AbsolParentMomIdleToWalk;

		public void ABParentMom_IdleToController()
		{
			Load_ABParentMom_idleToRun();
			Load_ABParentMom_idleToWalk();
		}
		private void Load_ABParentMom_idleToRun()
		{
			AbsolParentMomIdleToRun.ABParentMom_IdleToRunController();
		}
		private void Load_ABParentMom_idleToWalk()
		{
			AbsolParentMomIdleToWalk.ABParentMom_IdleToWalkController();
		}
	}
}