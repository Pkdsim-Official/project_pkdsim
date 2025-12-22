using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.movementbasedanimations.Strafing
{
	public class GL_LFS_Strafing : MonoBehaviour 
	{
		private GL_LFS_StrafeLeft GL_strafeleft;
		
		private GL_LFS_StrafeRight GL_straferight;

		public void GL_LFS_StrafingController()
		{
			if (GL_strafeleft == null)
			{
				GL_strafeleft = GetComponent<GL_LFS_StrafeLeft>();
				Load_GL_LFS_StrafeLeft();
			}
			if (GL_straferight == null)
			{
				GL_straferight = GetComponent<GL_LFS_StrafeRight>();
				Load_GL_LFS_StrafeRight();
			}
			

		}
		private void Load_GL_LFS_StrafeRight()
		{
			GL_straferight.GL_LFS_StrafeRightController();
		}
		
		private void Load_GL_LFS_StrafeLeft()
		{
			GL_strafeleft.GL_LFS_StrafeLeftController();
		}
	}
}