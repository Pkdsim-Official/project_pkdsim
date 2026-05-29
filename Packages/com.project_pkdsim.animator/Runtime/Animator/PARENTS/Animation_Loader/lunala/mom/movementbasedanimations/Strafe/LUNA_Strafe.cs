using project_pkdsim.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Strafing
{
	public class LUNAParent_Strafing : MonoBehaviour 
	{
		private LUNA_StrafeLeft LUNA_strafeleft;
		
		private LUNA_StrafeRight LUNA_straferight;

		public void LUNAParent_StrafingController()
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