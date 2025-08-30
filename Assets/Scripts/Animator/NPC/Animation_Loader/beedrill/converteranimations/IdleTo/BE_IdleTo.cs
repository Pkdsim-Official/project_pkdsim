using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Beedrill.converteranimations.IdleTo
{
	public class BEIdleTo : MonoBehaviour 
	{
		private BEIdleToRun BeedrillIdleToRun;
		private BEIdleToWalk BeedrillIdleToWalk;

		public void BEIdleToController()
		{
			Load_BEidleToRun();
			Load_BEidleToWalk();
		}
		private void Load_BEidleToRun()
		{
			BeedrillIdleToRun.BEIdleToRunController();
		}
		private void Load_BEidleToWalk()
		{
			BeedrillIdleToWalk.BEIdleToWalkController();
		}
	}
}