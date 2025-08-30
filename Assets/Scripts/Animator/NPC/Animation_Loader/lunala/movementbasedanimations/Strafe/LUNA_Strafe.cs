using project_pkdsim.Models.ANIMATOR.NPC.Lunala.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Lunala.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Lunala.movementbasedanimations.Strafe
{
	public class LUNA_Strafing : MonoBehaviour 
	{
		private LUNA_StrafeLeft LUNA_strafeleft;
		
		private LUNA_StrafeRight LUNA_straferight;

		public void LUNA_StrafingController()
		{
			if (LUNA_strafeleft == null)
			{
				LUNA_strafeleft = GetComponent<LUNA_StrafeLeft>();
				Load_LUNA_StrafeLeft();
			}
			if (LUNA_straferight == null)
			{
				LUNA_straferight = GetComponent<LUNA_StrafeRight>();
				Load_LUNA_StrafeRight();
			}
			

		}
		private void Load_LUNA_StrafeRight()
		{
			LUNA_straferight.LUNA_StrafeRightController();
		}
		
		private void Load_LUNA_StrafeLeft()
		{
			LUNA_strafeleft.LUNA_StrafeLeftController();
		}
	}
}