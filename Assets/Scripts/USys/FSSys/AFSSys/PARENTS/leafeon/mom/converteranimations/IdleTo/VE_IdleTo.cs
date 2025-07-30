using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Mom.converteranimations.IdleTo
{
	public class LEParentMom_IdleTo : MonoBehaviour 
	{
		private LEParentMom_IdleToRun LeafeonParentMomIdleToRun;
		private LEParentMom_IdleToWalk LeafeonParentMomIdleToWalk;

		public void LEParentMom_IdleToController()
		{
			Load_LEParentMom_idleToRun();
			Load_LEParentMom_idleToWalk();
		}
		private void Load_LEParentMom_idleToRun()
		{
			LeafeonParentMomIdleToRun.LEParentMom_IdleToRunController();
		}
		private void Load_LEParentMom_idleToWalk()
		{
			LeafeonParentMomIdleToWalk.LEParentMom_IdleToWalkController();
		}
	}
}