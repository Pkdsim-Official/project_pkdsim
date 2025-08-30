using project_pkdsim.Models.ANIMATOR.NPC.Lucario.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Models.ANIMATOR.NPC.Lucario.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Lucario.converteranimations.IdleTo
{
	public class LUCAIdleTo : MonoBehaviour 
	{
		private LUCAIdleToRun LucarioIdleToRun;
		private LUCAIdleToWalk LucarioIdleToWalk;

		public void LUCAIdleToController()
		{
			Load_LUCAidleToRun();
			Load_LUCAidleToWalk();
		}
		private void Load_LUCAidleToRun()
		{
			LucarioIdleToRun.LUCAIdleToRunController();
		}
		private void Load_LUCAidleToWalk()
		{
			LucarioIdleToWalk.LUCAIdleToWalkController();
		}
	}
}