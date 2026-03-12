using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.idlebaseanimation.IdleSitting;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.idlebaseanimation
{
	public class Dragapult_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private DR_LFS_IdleStanding Dragapult_LFS_idlestanding;
		
		private DR_LFS_IdleSitting Dragapult_LFS_idlesitting;
		
		public void	DR_LFS_IdleAnimatorController()
		{
			DR_LFS_IdleStandingAnimatorController();
			DR_LFS_IdleSittingAnimatorController();
		}
		private void DR_LFS_IdleStandingAnimatorController()
		{
			Dragapult_LFS_idlestanding.DR_LFS_IdleStandingController();
		}
		private void DR_LFS_IdleSittingAnimatorController()
		{
			Dragapult_LFS_idlesitting.DR_LFS_IdleSittingController();
		}
	}
}