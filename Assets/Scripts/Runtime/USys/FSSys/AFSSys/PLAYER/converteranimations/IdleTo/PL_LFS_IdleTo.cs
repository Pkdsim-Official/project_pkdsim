using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.PLAYER.converteranimations.IdleTo.IdleToRun;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.PLAYER.converteranimations.IdleTo.IdleToWalk;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.PLAYER.converteranimations.IdleTo
{
	public class PL_LFS_IdleTo : MonoBehaviour 
	{

		private PL_LFS_IdleToRun Player_LFS_IdleToRun;
		private PL_LFS_IdleToWalk Player_LFS_IdleToWalk;
		public void PL_LFS_IdleToController()
		{
			Load_PL_LFS_idleToRun();
			Load_PL_LFS_idleToWalk();
		}
		private void Load_PL_LFS_idleToRun()
		{
			Player_LFS_IdleToRun.PL_LFS_IdleToRunController();
		}
		private void Load_PL_LFS_idleToWalk()
		{
			Player_LFS_IdleToWalk.PL_LFS_IdleToWalkController();
		}
	}
}