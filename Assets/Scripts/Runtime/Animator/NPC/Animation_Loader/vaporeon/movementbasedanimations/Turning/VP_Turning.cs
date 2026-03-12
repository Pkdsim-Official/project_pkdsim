using Project_Pkdsim.ANIMATOR.Npcs.Vaporeon.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.ANIMATOR.Npcs.Vaporeon.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Vaporeon.movementbasedanimations.Turning
{
	public class VP_Turning : MonoBehaviour	
	{
		private VP_TurnLeft VP_turnleft;
		private VP_TurnRight VP_turnright;

		public void VP_TurningController()
		{
			if (VP_turnleft == null)
			{
				Load_VP_turnLeft();
			}
			if (VP_turnright == null)
			{
				Load_VP_turnRight();
			}
		}

		private void Load_VP_turnRight()
		{
			VP_turnright.VP_TurnRightController();
		}
		
		private void Load_VP_turnLeft()
		{
			VP_turnleft.VP_TurnLeftController();
		}
	}
}