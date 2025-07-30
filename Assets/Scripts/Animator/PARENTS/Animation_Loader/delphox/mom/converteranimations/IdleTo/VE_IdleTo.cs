using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo
{
	public class VEParentMom_IdleTo : MonoBehaviour 
	{
		private VEParentMom_IdleToRun DelphoxParentMomIdleToRun;
		private VEParentMom_IdleToWalk DelphoxParentMomIdleToWalk;

		public void VEParentMom_IdleToController()
		{
			Load_VEParentMom_idleToRun();
			Load_VEParentMom_idleToWalk();
		}
		private void Load_VEParentMom_idleToRun()
		{
			DelphoxParentMomIdleToRun.VEParentMom_IdleToRunController();
		}
		private void Load_VEParentMom_idleToWalk()
		{
			DelphoxParentMomIdleToWalk.VEParentMom_IdleToWalkController();
		}
	}
}