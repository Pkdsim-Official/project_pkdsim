using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.converteranimations.IdleTo
{
	public class VEParentDad_IdleTo : MonoBehaviour 
	{
		private VEParentDad_IdleToRun VespiquenParentDadIdleToRun;
		private VEParentDad_IdleToWalk VespiquenParentDadIdleToWalk;

		public void VEParentDad_IdleToController()
		{
			Load_VEParentDad_idleToRun();
			Load_VEParentDad_idleToWalk();
		}
		private void Load_VEParentDad_idleToRun()
		{
			VespiquenParentDadIdleToRun.VEParentDad_IdleToRunController();
		}
		private void Load_VEParentDad_idleToWalk()
		{
			VespiquenParentDadIdleToWalk.VEParentDad_IdleToWalkController();
		}
	}
}