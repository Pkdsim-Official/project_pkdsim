using project_pkdsim.ANIMATOR.NPC.Zoroark.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.NPC.Zoroark.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Zoroark.movementbasedanimations.Strafing
{
	public class Z_Strafing : MonoBehaviour 
	{
		private Z_StrafeLeft Z_strafeleft;
		
		private Z_StrafeRight Z_straferight;

		public void Z_StrafingController()
		{
			if (Z_strafeleft == null)
			{
				Load_Z_StrafeLeft();
			}
			if (Z_straferight == null)
			{
				Load_Z_StrafeRight();
			}
			

		}
		private void Load_Z_StrafeRight()
		{
			Z_straferight.Z_StrafeRightController();
		}
		
		private void Load_Z_StrafeLeft()
		{
			Z_strafeleft.Z_StrafeLeftController();
		}
	}
}