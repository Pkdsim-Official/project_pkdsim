using Project_Pkdsim.ANIMATOR.Npcs.Dragapult.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.ANIMATOR.Npcs.Dragapult.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Dragapult.movementbasedanimations.Turning
{
	public class DR_Turning : MonoBehaviour	
	{
		private DR_TurnLeft DR_turnleft;
		private DR_TurnRight DR_turnright;

		public void DR_TurningController()
		{
			if (DR_turnleft == null)
			{
				Load_DR_turnLeft();
			}
			if (DR_turnright == null)
			{
				Load_DR_turnRight();
			}
		}

		private void Load_DR_turnRight()
		{
			DR_turnright.DR_TurnRightController();
		}
		
		private void Load_DR_turnLeft()
		{
			DR_turnleft.DR_TurnLeftController();
		}
	}
}