using project_pkdsim.ANIMATOR.Npcs.Lucario.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Npcs.Lucario.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Lucario.movementbasedanimations.Turning
{
	public class LUCA_Turning : MonoBehaviour	
	{
		private LUCA_TurnLeft LUCA_turnleft;
		private LUCA_TurnRight LUCA_turnright;

		public void LUCA_TurningController()
		{
			if (LUCA_turnleft != null)
			{
				Load_LUCA_turnLeft();
			}

			if (LUCA_turnright != null)
			{
				Load_LUCA_turnRight();
			}
			
		}
		private void Load_LUCA_turnRight()
		{
			LUCA_turnright.LUCA_TurnRightController();
		}
		
		private void Load_LUCA_turnLeft()
		{
			LUCA_turnleft.LUCA_TurnLeftController();
		}
	}
}