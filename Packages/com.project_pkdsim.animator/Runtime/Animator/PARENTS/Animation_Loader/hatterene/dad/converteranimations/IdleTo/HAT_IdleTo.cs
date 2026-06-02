using project_pkdsim.ANIMATOR.Parents.Hatterene.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Hatterene.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Hatterene.converteranimations.IdleTo
{
	public class HAT_IdleTo : MonoBehaviour 
	{
		
		private HAT_IdleToRun HattereneIdleToRun;
		private HAT_IdleToWalk HattereneIdleToWalk;
		public void HAT_IdleToController()
		{
			Load_HAT_idleToRun();
			Load_HAT_idleToWalk();
		}
		private void Load_HAT_idleToRun()
		{
			HattereneIdleToRun.HAT_IdleToRunController();
		}
		private void Load_HAT_idleToWalk()
		{
			HattereneIdleToWalk.HAT_IdleToWalkController();
		}
	}
}