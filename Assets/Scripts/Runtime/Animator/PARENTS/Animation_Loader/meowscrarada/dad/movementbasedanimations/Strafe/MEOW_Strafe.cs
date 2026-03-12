using Project_Pkdsim.ANIMATOR.Parents.Meowscarada.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.ANIMATOR.Parents.Meowscarada.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Meowscarada.movementbasedanimations.Strafing
{
	public class MEOWParent_Strafing : MonoBehaviour 
	{
		private MEOW_StrafeLeft MEOW_strafeleft;
		
		private MEOW_StrafeRight MEOW_straferight;

		public void MEOWParent_StrafingController()
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