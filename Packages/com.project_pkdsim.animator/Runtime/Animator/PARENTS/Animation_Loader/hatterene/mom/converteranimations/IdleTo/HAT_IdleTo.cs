using project_pkdsim.ANIMATOR.Parents.Hatterene.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Hatterene.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Hatterene.Mom.converteranimations.IdleTo
{
	public class HATIdleTo : MonoBehaviour 
	{
		
		private HATIdleToRun HattereneIdleToRun;
		private HATIdleToWalk HattereneIdleToWalk;
		public void HAT_IdleToController()
		{
			Load_HATidleToRun();
			Load_HATidleToWalk();
		}
		private void Load_HATidleToRun()
		{
			HattereneIdleToRun.HATIdleToRunController();
		}
		private void Load_HATidleToWalk()
		{
			HattereneIdleToWalk.HATIdleToWalkController();
		}
	}
}