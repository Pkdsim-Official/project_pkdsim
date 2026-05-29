using project_pkdsim.ANIMATOR.Parents.Garchomp.Dad.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Parents.Garchomp.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Garchomp.Dad.movementbasedanimations.Strafing
{
	public class GARCParent_Strafing : MonoBehaviour 
	{
		private GARC_StrafeLeft GARC_strafeleft;
		
		private GARC_StrafeRight GARC_straferight;

		public void GARCParent_StrafingController()
		{
			if (GARC_strafeleft == null)
			{
				Load_GARC_StrafeLeft();
			}
			if (GARC_straferight == null)
			{
				Load_GARC_StrafeRight();
			}
			

		}
		private void Load_GARC_StrafeRight()
		{
			GARC_straferight.GARC_StrafeRightController();
		}
		
		private void Load_GARC_StrafeLeft()
		{
			GARC_strafeleft.GARC_StrafeLeftController();
		}
	}
}