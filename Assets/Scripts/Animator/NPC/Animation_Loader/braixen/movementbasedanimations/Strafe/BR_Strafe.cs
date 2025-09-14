using project_pkdsim.ANIMATOR.Npcs.Braixen.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Npcs.Braixen.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Braixen.movementbasedanimations.Strafing
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