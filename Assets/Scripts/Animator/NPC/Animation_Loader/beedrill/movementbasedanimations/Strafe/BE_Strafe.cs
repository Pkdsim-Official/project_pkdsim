using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Beedrill.movementbasedanimations.Strafe
{
	public class BE_Strafing : MonoBehaviour 
	{
		private BE_StrafeLeft BE_strafeleft;
		
		private BE_StrafeRight BE_straferight;

		public void BE_StrafingController()
		{
			if (BE_strafeleft == null)
			{
				Load_BEStrafeLeft();
			}
			if (BE_straferight == null)
			{
				Load_BEStrafeRight();
			}
			

		}
		private void Load_BEStrafeRight()
		{
			BE_straferight.BE_StrafeRightController();
		}
		
		private void Load_BEStrafeLeft()
		{
			BE_strafeleft.BE_StrafeLeftController();
		}
	}
}