using project_pkdsim.ANIMATOR.Npcs.Lunala.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Npcs.Lunala.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Lunala.movementbasedanimations.Turning
{
	public class LUNA_Turning : MonoBehaviour	
	{
		private LUNA_TurnLeft LUNA_turnleft;
		private LUNA_TurnRight LUNA_turnright;

		public void LUNA_TurningController()
		{
			if (LUNA_turnleft == null)
			{
				Load_LUNA_turnLeft();
			}

			if (LUNA_turnright == null)
			{
				Load_LUNA_turnRight();
			}
		}

		private void Load_LUNA_turnRight()
		{
			LUNA_turnright.LUNA_TurnRightController();
		}
		
		private void Load_LUNA_turnLeft()
		{
			LUNA_turnleft.LUNA_TurnLeftController();
		}
	}
}