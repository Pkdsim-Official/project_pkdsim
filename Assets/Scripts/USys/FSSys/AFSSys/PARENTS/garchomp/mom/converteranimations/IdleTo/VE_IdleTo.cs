using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.converteranimations.IdleTo
{
	public class GARCParentMom_IdleTo : MonoBehaviour 
	{
		private GARCParentMom_IdleToRun GarchompParentMomIdleToRun;
		private GARCParentMom_IdleToWalk GarchompParentMomIdleToWalk;

		public void GARCParentMom_IdleToController()
		{
			Load_GARCParentMom_idleToRun();
			Load_GARCParentMom_idleToWalk();
		}
		private void Load_GARCParentMom_idleToRun()
		{
			GarchompParentMomIdleToRun.GARCParentMom_IdleToRunController();
		}
		private void Load_GARCParentMom_idleToWalk()
		{
			GarchompParentMomIdleToWalk.GARCParentMom_IdleToWalkController();
		}
	}
}