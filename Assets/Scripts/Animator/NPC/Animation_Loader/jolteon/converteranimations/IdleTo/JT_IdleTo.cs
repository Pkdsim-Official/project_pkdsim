using project_pkdsim.ANIMATOR.NPC.Jolteon.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.NPC.Jolteon.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Jolteon.converteranimations.IdleTo
{
	public class JT_IdleTo : MonoBehaviour 
	{
		private JT_IdleToRun JT_IdleToRun;
		private JT_IdleToWalk JT_IdleToWalk;
		
		public void JT_IdleToController()
		{
			Load_JT_idleToRun();
			Load_JT_idleToWalk();
		}
		private void Load_JT_idleToRun()
		{
			JT_IdleToRun.JT_IdleToRunController();
		}
		private void Load_JT_idleToWalk()
		{
			JT_IdleToWalk.JT_IdleToWalkController();
		}
	}
}