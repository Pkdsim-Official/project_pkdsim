using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.movementbasedanimations.Strafing
{
	public class FR_LFS_Strafing : MonoBehaviour 
	{
		private FR_LFS_StrafeLeft FR_strafeleft;
		
		private FR_LFS_StrafeRight FR_straferight;

		public void FR_LFS_StrafingController()
		{
			if (FR_strafeleft == null)
			{
				FR_strafeleft = GetComponent<FR_LFS_StrafeLeft>();
				Load_FR_LFS_StrafeLeft();
			}
			if (FR_straferight == null)
			{
				FR_straferight = GetComponent<FR_LFS_StrafeRight>();
				Load_FR_LFS_StrafeRight();
			}
			

		}
		private void Load_FR_LFS_StrafeRight()
		{
			FR_straferight.FR_LFS_StrafeRightController();
		}
		
		private void Load_FR_LFS_StrafeLeft()
		{
			FR_strafeleft.FR_LFS_StrafeLeftController();
		}
	}
}