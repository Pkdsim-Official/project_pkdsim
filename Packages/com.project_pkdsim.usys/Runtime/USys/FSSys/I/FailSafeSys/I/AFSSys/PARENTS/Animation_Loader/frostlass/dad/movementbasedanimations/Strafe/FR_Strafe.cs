using project_pkdsim.ANIMATOR.Parents.Frostlass.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Parents.Frostlass.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.movementbasedanimations.Strafing
{
	public class FRParent_Strafing : MonoBehaviour 
	{
		private FRStrafeLeft FR_strafeleft;
		
		private FRStrafeRight FR_straferight;

		public void FRParent_StrafingController()
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