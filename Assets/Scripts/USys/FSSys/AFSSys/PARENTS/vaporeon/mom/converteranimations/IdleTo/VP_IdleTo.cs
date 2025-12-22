using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.converteranimations.IdleTo
{
	public class VPParentMom_IdleTo : MonoBehaviour 
	{
		private VPParentMom_IdleToRun VaporeonParentMomIdleToRun;
		private VPParentMom_IdleToWalk VaporeonParentMomIdleToWalk;

		public void VPParentMom_IdleToController()
		{
			Load_VPParentMom_idleToRun();
			Load_VPParentMom_idleToWalk();
		}
		private void Load_VPParentMom_idleToRun()
		{
			VaporeonParentMomIdleToRun.VPParentMom_IdleToRunController();
		}
		private void Load_VPParentMom_idleToWalk()
		{
			VaporeonParentMomIdleToWalk.VPParentMom_IdleToWalkController();
		}
	}
}