using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo
{
	public class VEParentMom_IdleTo : MonoBehaviour 
	{
		private VEParentMom_IdleToRun AbsolParentMomIdleToRun;
		private VEParentMom_IdleToWalk AbsolParentMomIdleToWalk;

		public void VEParentMom_IdleToController()
		{
			Load_VEParentMom_idleToRun();
			Load_VEParentMom_idleToWalk();
		}
		private void Load_VEParentMom_idleToRun()
		{
			AbsolParentMomIdleToRun.VEParentMom_IdleToRunController();
		}
		private void Load_VEParentMom_idleToWalk()
		{
			AbsolParentMomIdleToWalk.VEParentMom_IdleToWalkController();
		}
	}
}