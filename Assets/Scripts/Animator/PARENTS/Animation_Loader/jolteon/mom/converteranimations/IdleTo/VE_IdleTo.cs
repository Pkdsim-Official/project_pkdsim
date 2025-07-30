using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo
{
	public class VEParentMom_IdleTo : MonoBehaviour 
	{
		private VEParentMom_IdleToRun JolteonParentMomIdleToRun;
		private VEParentMom_IdleToWalk JolteonParentMomIdleToWalk;

		public void VEParentMom_IdleToController()
		{
			Load_VEParentMom_idleToRun();
			Load_VEParentMom_idleToWalk();
		}
		private void Load_VEParentMom_idleToRun()
		{
			JolteonParentMomIdleToRun.VEParentMom_IdleToRunController();
		}
		private void Load_VEParentMom_idleToWalk()
		{
			JolteonParentMomIdleToWalk.VEParentMom_IdleToWalkController();
		}
	}
}