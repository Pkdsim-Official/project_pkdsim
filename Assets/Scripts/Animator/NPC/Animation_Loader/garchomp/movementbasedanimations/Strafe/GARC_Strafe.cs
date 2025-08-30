using project_pkdsim.Models.ANIMATOR.NPC.Garchomp.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Garchomp.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Garchomp.movementbasedanimations.Strafe
{
	public class GARC_Strafing : MonoBehaviour 
	{
		private GARC_StrafeLeft GARC_strafeleft;
		
		private GARC_StrafeRight GARC_straferight;

		public void GARC_StrafingController()
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