using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.IdleTo
{
	public class VEParentDad_IdleTo : MonoBehaviour 
	{
		private VEParentDad_IdleToRun VespiquenIdleToRun;
		private VEParentDad_IdleToWalk VespiquenIdleToWalk;

		public void VEParentDad_IdleToController()
		{
			Load_VEParentDad_idleToRun();
			Load_VEParentDad_idleToWalk();
		}
		private void Load_VEParentDad_idleToRun()
		{
			VespiquenIdleToRun.VEParentDad_IdleToRunController();
		}
		private void Load_VEParentDad_idleToWalk()
		{
			VespiquenIdleToWalk.VEParentDad_IdleToWalkController();
		}
	}
}