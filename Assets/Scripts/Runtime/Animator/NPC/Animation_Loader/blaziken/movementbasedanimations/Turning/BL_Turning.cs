using Project_Pkdsim.ANIMATOR.Npcs.Blaziken.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.ANIMATOR.Npcs.Blaziken.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Blaziken.movementbasedanimations.Turning
{
	public class BL_Turning : MonoBehaviour	
	{
		private BL_TurnLeft BL_turnleft;
		private BL_TurnRight BL_turnright;

		public void BL_TurningController()
		{
			if (BL_turnleft == null)
			{
				Load_BL_turnLeft();
			}
			if (BL_turnright == null)
			{
				Load_BL_turnRight();
			}
		}

		private void Load_BL_turnRight()
		{
			BL_turnright.BL_TurnRightController();
		}
		
		private void Load_BL_turnLeft()
		{
			BL_turnleft.BL_TurnLeftController();
		}
	}
}