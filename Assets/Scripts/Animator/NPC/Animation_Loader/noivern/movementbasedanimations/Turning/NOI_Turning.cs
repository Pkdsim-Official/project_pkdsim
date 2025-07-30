using project_pkdsim.ANIMATOR.Npcs.Noivern.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Npcs.Noivern.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Noivern.movementbasedanimations.Turning
{
	public class NOI_Turning : MonoBehaviour	
	{
		private NOI_TurnLeft NOI_turnleft;
		private NOI_TurnRight NOI_turnright;

		public void NOI_TurningController()
		{
			if (NOI_turnleft == null)
			{
				Load_NOI_turnLeft();
			}

			if (NOI_turnright == null)
			{
				Load_NOI_turnRight();
			}
		}

		private void Load_NOI_turnRight()
		{
			NOI_turnright.NOI_TurnRightController();
		}
		
		private void Load_NOI_turnLeft()
		{
			NOI_turnleft.NOI_TurnLeftController();
		}
	}
}