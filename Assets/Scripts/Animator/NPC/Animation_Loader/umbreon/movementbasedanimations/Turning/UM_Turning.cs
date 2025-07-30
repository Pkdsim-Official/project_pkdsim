using project_pkdsim.ANIMATOR.Npcs.Umbreon.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Npcs.Umbreon.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Umbreon.movementbasedanimations.Turning
{
	public class UM_Turning : MonoBehaviour	
	{
		private UM_TurnLeft UM_turnleft;
		private UM_TurnRight UM_turnright;

		public void UM_TurningController()
		{
			if (UM_turnleft == null)
			{
				Load_UM_turnLeft();
			}
			if (UM_turnright == null)
			{
				Load_UM_turnRight();
			}
		}

		private void Load_UM_turnRight()
		{
			UM_turnright.UM_TurnRightController();
		}
		
		private void Load_UM_turnLeft()
		{
			UM_turnleft.UM_TurnLeftController();
		}
	}
}