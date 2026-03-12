using Project_Pkdsim.ANIMATOR.Npcs.Vespiquen.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Npcs.Vespiquen.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Vespiquen.converteranimations.IdleTo
{
	public class VE_IdleTo : MonoBehaviour 
	{
		private VE_IdleToRun Vespiquen_IdleToRun;
		private VE_IdleToWalk Vespiquen_IdleToWalk;

		public void VE_IdleToController()
		{
			Load_VEidleToRun();
			Load_VEidleToWalk();
		}
		private void Load_VEidleToRun()
		{
			Vespiquen_IdleToRun.VE_IdleToRunController();
		}
		private void Load_VEidleToWalk()
		{
			Vespiquen_IdleToWalk.VE_IdleToWalkController();
		}
	}
}