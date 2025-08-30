using project_pkdsim.Models.ANIMATOR.NPC.Meowscarada.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Meowscarada.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Meowscarada.movementbasedanimations.Turning
{
	public class MEOW_Turning : MonoBehaviour	
	{
		private MEOW_TurnLeft MEOW_turnleft;
		private MEOW_TurnRight MEOW_turnright;

		public void MEOW_TurningController()
		{
			if (MEOW_turnleft == null)
			{
				Load_MEOW_turnLeft();
			}
			if (MEOW_turnright == null)
			{
				Load_MEOW_turnRight();
			}
		}

		private void Load_MEOW_turnRight()
		{
			MEOW_turnright.MEOW_TurnRightController();
		}
		
		private void Load_MEOW_turnLeft()
		{
			MEOW_turnleft.MEOW_TurnLeftController();
		}
	}
}