using project_pkdsim.Models.ANIMATOR.NPC.Braixen.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Models.ANIMATOR.NPC.Braixen.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Braixen.converteranimations.IdleTo
{
	public class BR_IdleTo : MonoBehaviour 
	{
		private BR_IdleToRun BraixenIdleToRun;
		private BR_IdleToWalk BraixenIdleToWalk;
		public void BR_IdleToController()
		{
			Load_BR_IdleToRun();
			Load_BR_IdleToWalk();
		}
		private void Load_BR_IdleToRun()
		{
			BraixenIdleToRun.BR_IdleToRunController();
		}
		private void Load_BR_IdleToWalk()
		{
			BraixenIdleToWalk.BR_IdleToWalkController();
		}
	}
}