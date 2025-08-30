using project_pkdsim.Models.ANIMATOR.NPC.Braixen.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Models.ANIMATOR.NPC.Braixen.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Braixen.converteranimations.IdleTo
{
	public class BRIdleTo : MonoBehaviour 
	{
		private BRIdleToRun BraixenIdleToRun;
		private BRIdleToWalk BraixenIdleToWalk;
		public void BRIdleToController()
		{
			Load_BRidleToRun();
			Load_BRidleToWalk();
		}
		private void Load_BRidleToRun()
		{
			BraixenIdleToRun.BRIdleToRunController();
		}
		private void Load_BRidleToWalk()
		{
			BraixenIdleToWalk.BRIdleToWalkController();
		}
	}
}