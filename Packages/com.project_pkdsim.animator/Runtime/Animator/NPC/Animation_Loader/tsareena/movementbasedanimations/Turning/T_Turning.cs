using project_pkdsim.ANIMATOR.NPC.Tsareena.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.NPC.Tsareena.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Tsareena.movementbasedanimations.Turning
{
	public class T_Turning : MonoBehaviour	
	{
		private T_TurnLeft T_turnleft;
		private T_TurnRight T_turnright;

		public void T_TurningController()
		{
			if (T_turnleft != null)
			{
				Load_T_turnLeft();
			}

			if (T_turnright != null)
			{
				Load_T_turnRight();
			}
		}
		private void Load_T_turnRight()
		{
			T_turnright.T_TurnRightController();
		}
		
		private void Load_T_turnLeft()
		{
			T_turnleft.T_TurnLeftController();
		}
	}
}