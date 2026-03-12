using Project_Pkdsim.ANIMATOR.Npcs.Blaziken.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Npcs.Blaziken.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Blaziken.converteranimations.IdleTo
{
	public class BL_IdleTo : MonoBehaviour 
	{
		private BL_IdleToRun Blaziken_IdleToRun;
		private BL_IdleToWalk Blaziken_IdleToWalk;
		public void BL_IdleToController()
		{
			Load_BL_IdleToRun();
			Load_BL_IdleToWalk();
		}
		private void Load_BL_IdleToRun()
		{
			Blaziken_IdleToRun.BL_IdleToRunController();
		}
		private void Load_BL_IdleToWalk()
		{
			Blaziken_IdleToWalk.BL_IdleToWalkController();
		}
	}
}