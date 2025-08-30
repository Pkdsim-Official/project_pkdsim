using project_pkdsim.Models.ANIMATOR.NPC.Frostlass.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Models.ANIMATOR.NPC.Frostlass.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Frostlass.converteranimations.IdleTo
{
	public class FRIdleTo : MonoBehaviour 
	{
		private FRIdleToRun FrostlassIdleToRun;
		private FRIdleToWalk FrostlassIdleToWalk;
		public void FRIdleToController()
		{
			Load_FRIdleToRun();
			Load_FRIdleToWalk();
		}
		private void Load_FRIdleToRun()
		{
			FrostlassIdleToRun.FRIdleToRunController();
		}
		private void Load_FRIdleToWalk()
		{
			FrostlassIdleToWalk.FRIdleToWalkController();
		}
	}
}