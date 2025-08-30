using project_pkdsim.Models.ANIMATOR.NPC.Lunala.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.Models.ANIMATOR.NPC.Lunala.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Lunala.converteranimations.IdleTo
{
	public class LUNAIdleTo : MonoBehaviour 
	{
		private LUNAIdleToRun LunalaIdleToRun;
		private LUNAIdleToWalk LunalaIdleToWalk;

		public void LUNAIdleToController()
		{
			Load_LUNAidleToRun();
			Load_LUNAidleToWalk();
		}
		private void Load_LUNAidleToRun()
		{
			LunalaIdleToRun.LUNAIdleToRunController();
		}
		private void Load_LUNAidleToWalk()
		{
			LunalaIdleToWalk.LUNAIdleToWalkController();
		}
	}
}