using project_pkdsim.ANIMATOR.Npcs.Hatterene.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Npcs.Hatterene.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Hatterene.movementbasedanimations.Turning
{
	public class HAT_Turning : MonoBehaviour	
	{
		private HAT_TurnLeft HAT_turnleft;
		private HAT_TurnRight HAT_turnright;

		public void HAT_TurningController()
		{
			if (HAT_turnleft == null)
			{
				Load_HAT_turnLeft();
			}
			if (HAT_turnright == null)
			{
				Load_HAT_turnRight();
			}
		}

		private void Load_HAT_turnRight()
		{
			HAT_turnright.HAT_TurnRightController();
		}
		
		private void Load_HAT_turnLeft()
		{
			HAT_turnleft.HAT_TurnLeftController();
		}
	}
}