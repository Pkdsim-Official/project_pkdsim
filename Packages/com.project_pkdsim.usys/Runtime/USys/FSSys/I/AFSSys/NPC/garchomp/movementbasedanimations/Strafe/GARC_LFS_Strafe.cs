using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.movementbasedanimations.Strafing
{
	public class GARC_LFS_Strafing : MonoBehaviour 
	{
		private GARC_LFS_StrafeLeft GARC_strafeleft;
		
		private GARC_LFS_StrafeRight GARC_straferight;

		public void GARC_LFS_StrafingController()
		{
			if (GARC_strafeleft == null)
			{
				GARC_strafeleft = GetComponent<GARC_LFS_StrafeLeft>();
				Load_GARC_LFS_StrafeLeft();
			}
			if (GARC_straferight == null)
			{
				GARC_straferight = GetComponent<GARC_LFS_StrafeRight>();
				Load_GARC_LFS_StrafeRight();
			}
			

		}
		private void Load_GARC_LFS_StrafeRight()
		{
			GARC_straferight.GARC_LFS_StrafeRightController();
		}
		
		private void Load_GARC_LFS_StrafeLeft()
		{
			GARC_strafeleft.GARC_LFS_StrafeLeftController();
		}
	}
}