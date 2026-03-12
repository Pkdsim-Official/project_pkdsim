using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.PLAYER.idlebaseanimation.IdleSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.PLAYER.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.PLAYER.idlebaseanimation
{
	public class Player_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private PL_LFS_IdleStanding Player_LFS_idlestanding;
		
		private PL_LFS_IdleSitting Player_LFS_idlesitting;
		
		public void	PL_LFS_IdleAnimatorController()
		{
			PL_LFS_IdleStandingAnimatorController();
			PL_LFS_IdleSittingAnimatorController();
		}
		private void PL_LFS_IdleStandingAnimatorController()
		{
			Player_LFS_idlestanding.PL_LFS_IdleStandingController();
		}
		private void PL_LFS_IdleSittingAnimatorController()
		{
			Player_LFS_idlesitting.PL_LFS_IdleSittingController();
		}
	}
}