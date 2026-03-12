using Project_Pkdsim.ANIMATOR.Parents.Lunala.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Parents.Lunala.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Lunala.converteranimations.IdleTo
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