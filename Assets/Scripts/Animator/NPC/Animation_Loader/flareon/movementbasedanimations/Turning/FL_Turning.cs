using project_pkdsim.Models.ANIMATOR.NPC.Flareon.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Flareon.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Flareon.movementbasedanimations.Turning
{
	public class FL_Turning : MonoBehaviour	
	{
		private FL_TurnLeft FL_turnleft;
		private FL_TurnRight FL_turnright;

		public void FL_TurningController()
		{
			if (FL_turnleft == null)
			{
				Load_FL_turnLeft();
			}
			if (FL_turnright == null)
			{
				Load_FL_turnRight();
			}
		}

		private void Load_FL_turnRight()
		{
			FL_turnright.FL_TurnRightController();
		}
		
		private void Load_FL_turnLeft()
		{
			FL_turnleft.FL_TurnLeftController();
		}
	}
}