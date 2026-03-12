using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.idlebaseanimation.IdleSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.idlebaseanimation
{
	public class Delphox_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private DL_LFS_IdleStanding DL_LFS_idlestanding;
		
		private DL_LFS_IdleSitting DL_LFS_idlesitting;
		
		public void	DL_LFS_IdleAnimatorController()
		{
			DL_LFS_IdleStandingAnimatorController();
			DL_LFS_IdleSittingAnimatorController();
		}
		private void DL_LFS_IdleStandingAnimatorController()
		{
			DL_LFS_idlestanding.DL_LFS_IdleStandingController();
		}
		private void DL_LFS_IdleSittingAnimatorController()
		{
			DL_LFS_idlesitting.DL_LFS_IdleSittingController();
		}
	}
}