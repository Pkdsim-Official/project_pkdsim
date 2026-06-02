using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.converteranimations.IdleTo
{
	public class VespiquenParentMom_IdleTo : MonoBehaviour 
	{
		private VEParentMom_IdleToRun VespiquenIdleToRun;
		private VEParentMom_IdleToWalk VespiquenIdleToWalk;

		public void VEParentMom_IdleToController()
		{
			Load_VEParentMom_idleToRun();
			Load_VEParentMom_idleToWalk();
		}
		private void Load_VEParentMom_idleToRun()
		{
			VespiquenIdleToRun.VEParentMom_IdleToRunController();
		}
		private void Load_VEParentMom_idleToWalk()
		{
			VespiquenIdleToWalk.VEParentMom_IdleToWalkController();
		}
	}
}