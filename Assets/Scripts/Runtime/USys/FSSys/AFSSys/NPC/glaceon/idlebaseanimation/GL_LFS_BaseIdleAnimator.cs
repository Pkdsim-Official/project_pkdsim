using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.idlebaseanimation.IdleStanding;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.idlebaseanimation.IdleSitting;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.idlebaseanimation
{
	public class Glaceon_LFS_IdleAnimatorController : MonoBehaviour 
	{
		private GL_LFS_IdleStanding Glaceon_LFS_idlestanding;
		
		private GL_LFS_IdleSitting Glaceon_LFS_idlesitting;
		
		public void GL_LFS_IdleAnimatorController()
		{
			GL_LFS_IdleStandingAnimatorController();
			GL_LFS_IdleSittingAnimatorController();
		}
		private void GL_LFS_IdleStandingAnimatorController()
		{
			Glaceon_LFS_idlestanding.GL_LFS_IdleStandingController();
		}
		private void GL_LFS_IdleSittingAnimatorController()
		{
			Glaceon_LFS_idlesitting.GL_LFS_IdleSittingController();
		}
	}
}