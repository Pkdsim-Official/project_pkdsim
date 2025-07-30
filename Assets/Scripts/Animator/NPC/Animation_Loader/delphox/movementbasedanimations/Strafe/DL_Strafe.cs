using project_pkdsim.ANIMATOR.NPC.Delphox.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.NPC.Delphox.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Delphox.movementbasedanimations.Strafing
{
	public class DL_Strafing : MonoBehaviour 
	{
		private DL_StrafeLeft DL_strafeleft;
		
		private DL_StrafeRight DL_straferight;

		public void DL_StrafingController()
		{
			if (DL_strafeleft == null)
			{
				Load_DL_StrafeLeft();
			}
			if (DL_straferight == null)
			{
				Load_DL_StrafeRight();
			}
		}

		private void Load_DL_StrafeRight()
		{
			DL_straferight.DL_StrafeRightController();
		}
		
		private void Load_DL_StrafeLeft()
		{
			DL_strafeleft.DL_StrafeLeftController();
		}
	}
}