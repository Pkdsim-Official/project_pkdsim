using Project_Pkdsim.ANIMATOR.Parents.Hatterene.Dad.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.ANIMATOR.Parents.Hatterene.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Hatterene.Dad.movementbasedanimations.Strafing
{
	public class HATParentDad_Strafing : MonoBehaviour 
	{
		private HAT_StrafeLeft HAT_strafeleft;
		
		private HAT_StrafeRight HAT_straferight;

		public void HATParentDad_StrafingController()
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