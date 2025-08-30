using project_pkdsim.Models.ANIMATOR.NPC.Braixen.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Braixen.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Braixen.movementbasedanimations.Strafe
{
	public class BR_Strafing : MonoBehaviour 
	{
		private BRStrafeLeft BR_strafeleft;
		
		private BRStrafeRight BR_straferight;

		public void BR_StrafingController()
		{
			if (BR_strafeleft == null)
			{
				BR_strafeleft = GetComponent<BRStrafeLeft>();
				Load_BRStrafeLeft();
			}
			if (BR_straferight == null)
			{
				BR_straferight = GetComponent<BRStrafeRight>();
				Load_BRStrafeRight();
			}
			

		}
		private void Load_BRStrafeRight()
		{
			BR_straferight.BRStrafeRightController();
		}
		
		private void Load_BRStrafeLeft()
		{
			BR_strafeleft.BRStrafeLeftController();
		}
	}
}