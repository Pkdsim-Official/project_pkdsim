using project_pkdsim.Models.ANIMATOR.NPC.Delphox.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Delphox.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Delphox.movementbasedanimations.Strafe
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