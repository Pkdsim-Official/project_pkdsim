using project_pkdsim.Models.ANIMATOR.NPC.Lopunny.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Lopunny.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Lopunny.movementbasedanimations.Strafe
{
	public class LO_Strafing : MonoBehaviour 
	{
		private LO_StrafeLeft LO_strafeleft;
		
		private LO_StrafeRight LO_straferight;

		public void LO_StrafingController()
		{
			if (LO_strafeleft == null)
			{
				Load_LO_StrafeLeft();
			}
			if (LO_straferight == null)
			{
				Load_LO_StrafeRight();
			}
			

		}
		private void Load_LO_StrafeRight()
		{
			LO_straferight.LO_StrafeRightController();
		}
		
		private void Load_LO_StrafeLeft()
		{
			LO_strafeleft.LO_StrafeLeftController();
		}
	}
}