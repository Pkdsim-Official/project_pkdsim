using project_pkdsim.Models.ANIMATOR.NPC.Frostlass.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Frostlass.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Frostlass.movementbasedanimations.Strafe
{
	public class FR_Strafing : MonoBehaviour 
	{
		private FRStrafeLeft FR_strafeleft;
		
		private FRStrafeRight FR_straferight;

		public void FR_StrafingController()
		{
			if (FR_strafeleft == null)
			{
				FR_strafeleft = GetComponent<FRStrafeLeft>();
				Load_FRStrafeLeft();
			}
			if (FR_straferight == null)
			{
				FR_straferight = GetComponent<FRStrafeRight>();
				Load_FRStrafeRight();
			}
			

		}
		private void Load_FRStrafeRight()
		{
			FR_straferight.FRStrafeRightController();
		}
		
		private void Load_FRStrafeLeft()
		{
			FR_strafeleft.FRStrafeLeftController();
		}
	}
}