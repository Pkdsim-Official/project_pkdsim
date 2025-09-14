using project_pkdsim.ANIMATOR.Npcs.Meowscarada.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Npcs.Meowscarada.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Meowscarada.movementbasedanimations.Strafing
{
	public class MEOW_Strafing : MonoBehaviour 
	{
		private MEOW_StrafeLeft MEOW_strafeleft;
		
		private MEOW_StrafeRight MEOW_straferight;

		public void MEOW_StrafingController()
		{
			if (MEOW_strafeleft == null)
			{
				Load_MEOW_StrafeLeft();
			}
			if (MEOW_straferight == null)
			{
				Load_MEOW_StrafeRight();
			}
			

		}
		private void Load_MEOW_StrafeRight()
		{
			MEOW_straferight.MEOW_StrafeRightController();
		}
		
		private void Load_MEOW_StrafeLeft()
		{
			MEOW_strafeleft.MEOW_StrafeLeftController();
		}
	}
}