using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.converteranimations.IdleTo
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