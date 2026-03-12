using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.idlebaseanimation.IdleSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.idlebaseanimation
{
	public class Tsareena_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private T_LFS_IdleStanding T_LFS_idlestanding;
		
		private T_LFS_IdleSitting T_LFS_idlesitting;
		
		public void	T_LFS_IdleAnimatorController()
		{
			T_LFS_IdleStandingAnimatorController();
			T_LFS_IdleSittingAnimatorController();
		}
		private void T_LFS_IdleStandingAnimatorController()
		{
			T_LFS_idlestanding.T_LFS_IdleStandingController();
		}
		private void T_LFS_IdleSittingAnimatorController()
		{
			T_LFS_idlesitting.T_LFS_IdleSittingController();
		}
	}
}