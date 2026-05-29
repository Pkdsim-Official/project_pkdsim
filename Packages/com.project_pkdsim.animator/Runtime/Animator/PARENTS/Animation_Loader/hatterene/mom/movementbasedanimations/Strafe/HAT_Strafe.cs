using project_pkdsim.ANIMATOR.Parents.Hatterene.Mom.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Parents.Hatterene.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Hatterene.Mom.movementbasedanimations.Strafing
{
	public class HATParent_Strafing : MonoBehaviour 
	{
		private HAT_StrafeLeft HAT_strafeleft;
		
		private HAT_StrafeRight HAT_straferight;

		public void HATParent_StrafingController()
		{
			if (HAT_strafeleft == null)
			{
				Load_HAT_StrafeLeft();
			}
			if (HAT_straferight == null)
			{
				Load_HAT_StrafeRight();
			}
			

		}
		private void Load_HAT_StrafeRight()
		{
			HAT_straferight.HAT_StrafeRightController();
		}
		
		private void Load_HAT_StrafeLeft()
		{
			HAT_strafeleft.HAT_StrafeLeftController();
		}
	}
}