using project_pkdsim.ANIMATOR.NPC.Flareon.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.NPC.Flareon.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Flareon.converteranimations.IdleTo
{
	public class FL_IdleTo : MonoBehaviour 
	{
		private FL_IdleToRun FL_IdleToRun;
		private FL_IdleToWalk FL_IdleToWalk;
		public void FL_IdleToController()
		{
			Load_FL_IdleToRun();
			Load_FL_IdleToWalk();
		}
		private void Load_FL_IdleToRun()
		{
			FL_IdleToRun.FL_IdleToRunningController();
		}
		private void Load_FL_IdleToWalk()
		{
			FL_IdleToWalk.FL_IdleToWalkController();
		}
	}
}