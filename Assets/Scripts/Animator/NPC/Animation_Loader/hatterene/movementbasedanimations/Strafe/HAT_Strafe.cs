using project_pkdsim.Models.ANIMATOR.NPC.Hatterene.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Hatterene.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Hatterene.movementbasedanimations.Strafing
{
	public class HAT_Strafing : MonoBehaviour 
	{
		private HAT_StrafeLeft HAT_strafeleft;
		
		private HAT_StrafeRight HAT_straferight;

		public void HAT_StrafingController()
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