using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.movementbasedanimations.Strafing
{
	public class C_LFS_Strafing : MonoBehaviour 
	{
		private C_LFS_StrafeLeft C_strafeleft;
		
		private C_LFS_StrafeRight C_straferight;

		public void C_LFS_StrafingController()
		{
			if (C_strafeleft == null)
			{
				C_strafeleft = GetComponent<C_LFS_StrafeLeft>();
				Load_C_LFS_StrafeLeft();
			}
			if (C_straferight == null)
			{
				C_straferight = GetComponent<C_LFS_StrafeRight>();
				Load_C_LFS_StrafeRight();
			}
			

		}
		private void Load_C_LFS_StrafeRight()
		{
			C_straferight.C_LFS_StrafeRightController();
		}
		
		private void Load_C_LFS_StrafeLeft()
		{
			C_strafeleft.C_LFS_StrafeLeftController();
		}
	}
}