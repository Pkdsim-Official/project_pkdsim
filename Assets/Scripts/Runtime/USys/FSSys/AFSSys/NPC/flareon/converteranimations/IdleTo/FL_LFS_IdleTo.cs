using Project_Pkdsim.ANIMATOR.Npcs.Flareon.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.ANIMATOR.Npcs.Flareon.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.converteranimations.IdleTo
{
	public class FL_LFS_IdleTo : MonoBehaviour 
	{
		private FL_LFS_IdleToRunning Flareon_LFS_IdleToRunning;
		private FL_LFS_IdleToWalking Flareon_LFS_IdleToWalking;

		public void FL_LFS_IdleToController()
		{
			Load_FL_LFS_IdleToRunning();
			Load_FL_LFS_IdleToWalking();
		}

		private void Load_FL_LFS_IdleToRunning()
		{
			Flareon_LFS_IdleToRunning.FL_LFS_IdleToRunningController();
		}
		
		private void Load_FL_LFS_IdleToWalking()
		{
			Flareon_LFS_IdleToWalking.FL_LFS_IdleToWalkingController();
		}

	}
}