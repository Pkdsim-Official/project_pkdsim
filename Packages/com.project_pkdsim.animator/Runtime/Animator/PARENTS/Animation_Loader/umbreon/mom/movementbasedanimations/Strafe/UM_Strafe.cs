using project_pkdsim.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations.Strafing
{
	public class UMParent_Strafing : MonoBehaviour 
	{
		private UM_StrafeLeft UM_strafeleft;
		
		private UM_StrafeRight UM_straferight;

		public void UMParent_StrafingController()
		{
			if (UM_strafeleft == null)
			{
				Load_UM_StrafeLeft();
			}
			if (UM_straferight == null)
			{
				Load_UM_StrafeRight();
			}
		}

		private void Load_UM_StrafeRight()
		{
			UM_straferight.UM_StrafeRightController();
		}
		
		private void Load_UM_StrafeLeft()
		{
			UM_strafeleft.UM_StrafeLeftController();
		}
	}
}