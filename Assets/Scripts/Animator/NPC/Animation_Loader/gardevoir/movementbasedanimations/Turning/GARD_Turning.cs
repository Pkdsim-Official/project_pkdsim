using project_pkdsim.ANIMATOR.Npcs.Gardevoir.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Npcs.Gardevoir.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Gardevoir.movementbasedanimations.Turning
{
	public class GARD_Turning : MonoBehaviour	
	{
		private GARD_TurnLeft GARD_turnleft;
		private GARD_TurnRight GARD_turnright;

		public void GARD_TurningController()
		{
			if (GARD_turnleft == null)
			{
				Load_GARD_turnLeft();
			}
			if (GARD_turnright == null)
			{
				Load_GARD_turnRight();
			}
		}

		private void Load_GARD_turnRight()
		{
			GARD_turnright.GARD_TurnRightController();
		}
		
		private void Load_GARD_turnLeft()
		{
			GARD_turnleft.GARD_TurnLeftController();
		}
	}
}