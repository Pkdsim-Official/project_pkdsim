using project_pkdsim.ANIMATOR.Npcs.Lucario.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Npcs.Lucario.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Lucario.movementbasedanimations.Strafing
{
	public class LUCA_Strafing : MonoBehaviour 
	{
		private LUCA_StrafeLeft LUCA_strafeleft;
		
		private LUCA_StrafeRight LUCA_straferight;

		public void LUCA_StrafingController()
		{
			if (LUCA_strafeleft == null)
			{
				LUCA_strafeleft = GetComponent<LUCA_StrafeLeft>();
				Load_LUCA_StrafeLeft();
			}
			if (LUCA_straferight == null)
			{
				LUCA_straferight = GetComponent<LUCA_StrafeRight>();
				Load_LUCA_StrafeRight();
			}
			

		}
		private void Load_LUCA_StrafeRight()
		{
			LUCA_straferight.LUCA_StrafeRightController();
		}
		
		private void Load_LUCA_StrafeLeft()
		{
			LUCA_strafeleft.LUCA_StrafeLeftController();
		}
	}
}