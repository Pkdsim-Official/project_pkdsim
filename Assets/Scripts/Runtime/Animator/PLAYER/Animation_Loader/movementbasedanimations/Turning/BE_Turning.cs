using Project_Pkdsim.ANIMATOR.Player.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.ANIMATOR.Player.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Player.movementbasedanimations.Turning
{
	public class Player_Turning : MonoBehaviour	
	{
		private Player_TurnLeft Player_turnleft;
		private Player_TurnRight Player_turnright;

		public void Player_TurningController()
		{
			if (Player_turnleft == null)
			{
				Load_Player_turnLeft();
			}
			if (Player_turnright == null)
			{
				Load_Player_turnRight();
			}
		}

		private void Load_Player_turnRight()
		{
			Player_turnright.Player_TurnRightController();
		}
		
		private void Load_Player_turnLeft()
		{
			Player_turnleft.Player_TurnLeftController();
		}
	}
}