using project_pkdsim.ANIMATOR.Parents.Lunala.Mom.converteranimations.IdleTo.IdleToRun;
using project_pkdsim.ANIMATOR.Parents.Lunala.Mom.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lunala.Mom.converteranimations.IdleTo
{
	public class LUNAIdleTo : MonoBehaviour 
	{
		private LUNAIdleToRun LunalaIdleToRun;
		private LUNAIdleToWalk LunalaIdleToWalk;

		public void LUNA_IdleToController()
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