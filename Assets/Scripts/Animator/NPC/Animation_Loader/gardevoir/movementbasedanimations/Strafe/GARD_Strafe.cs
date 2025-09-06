using project_pkdsim.ANIMATOR.NPC.Gardevoir.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.NPC.Gardevoir.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Gardevoir.movementbasedanimations.Strafing
{
	public class GARD_Strafing : MonoBehaviour 
	{
		private GARD_StrafeLeft GARD_strafeleft;
		
		private GARD_StrafeRight GARD_straferight;

		public void GARD_StrafingController()
		{
			if (GARD_strafeleft == null)
			{
				Load_GARD_StrafeLeft();
			}
			if (GARD_straferight == null)
			{
				Load_GARD_StrafeRight();
			}
			

		}
		private void Load_GARD_StrafeRight()
		{
			GARD_straferight.GARD_StrafeRightController();
		}
		
		private void Load_GARD_StrafeLeft()
		{
			GARD_strafeleft.GARD_StrafeLeftController();
		}
	}
}