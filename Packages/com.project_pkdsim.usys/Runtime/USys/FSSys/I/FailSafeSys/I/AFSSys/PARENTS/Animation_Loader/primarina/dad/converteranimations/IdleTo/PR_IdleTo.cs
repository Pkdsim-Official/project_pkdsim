using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Dad.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Dad.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Dad.converteranimations.IdleTo
{
	public class PRIdleTo : MonoBehaviour 
	{
		private PRIdleToRun PrimarinaIdleToRun;
		private PRIdleToWalk PrimarinaIdleToWalk;
		public void PR_IdleToController()
		{
			Load_PRIdleToRun();
			Load_PRIdleToWalk();
		}
		private void Load_PRIdleToRun()
		{
			PrimarinaIdleToRun.PRIdleToRunController();
		}
		private void Load_PRIdleToWalk()
		{
			PrimarinaIdleToWalk.PRIdleToWalkController();
		}
	}
}