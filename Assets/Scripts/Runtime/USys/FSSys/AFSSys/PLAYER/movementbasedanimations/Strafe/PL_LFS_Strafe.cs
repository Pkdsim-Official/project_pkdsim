using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.PLAYER.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.PLAYER.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.PLAYER.movementbasedanimations.Strafing
{
	public class PL_LFS_Strafing : MonoBehaviour 
	{
		private PL_LFS_StrafeLeft PL_strafeleft;
		
		private PL_LFS_StrafeRight PL_straferight;

		public void PL_LFS_StrafingController()
		{
			if (PL_strafeleft == null)
			{
				PL_strafeleft = GetComponent<PL_LFS_StrafeLeft>();
				Load_PL_LFS_StrafeLeft();
			}
			if (PL_straferight == null)
			{
				PL_straferight = GetComponent<PL_LFS_StrafeRight>();
				Load_PL_LFS_StrafeRight();
			}
		}
		private void Load_PL_LFS_StrafeRight()
		{
			PL_straferight.PL_LFS_StrafeRightController();
		}
		
		private void Load_PL_LFS_StrafeLeft()
		{
			PL_strafeleft.PL_LFS_StrafeLeftController();
		}
	}
}