using Project_Pkdsim.ANIMATOR.Npcs.Frostlass.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Npcs.Frostlass.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Frostlass.converteranimations.IdleTo
{
	public class FR_IdleTo : MonoBehaviour 
	{
		private FR_IdleToRun Frostlass_IdleToRun;
		private FR_IdleToWalk Frostlass_IdleToWalk;
		public void FR_IdleToController()
		{
			Load_FR_IdleToRun();
			Load_FR_IdleToWalk();
		}
		private void Load_FR_IdleToRun()
		{
			Frostlass_IdleToRun.FR_IdleToRunController();
		}
		private void Load_FR_IdleToWalk()
		{
			Frostlass_IdleToWalk.FR_IdleToWalkController();
		}
	}
}