using project_pkdsim.Models.ANIMATOR.NPC.Blaziken.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Blaziken.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Blaziken.movementbasedanimations.Strafing
{
	public class BL_Strafing : MonoBehaviour 
	{
		private BL_StrafeLeft BL_strafeleft;
		
		private BL_StrafeRight BL_straferight;

		public void BL_StrafingController()
		{
			if (BL_strafeleft == null)
			{
				BL_strafeleft = GetComponent<BL_StrafeLeft>();
				Load_BL_StrafeLeft();
			}
			if (BL_straferight == null)
			{
				BL_straferight = GetComponent<BL_StrafeRight>();
				Load_BL_StrafeRight();
			}
			

		}
		private void Load_BL_StrafeRight()
		{
			BL_straferight.BL_StrafeRightController();
		}
		
		private void Load_BL_StrafeLeft()
		{
			BL_strafeleft.BL_StrafeLeftController();
		}
	}
}