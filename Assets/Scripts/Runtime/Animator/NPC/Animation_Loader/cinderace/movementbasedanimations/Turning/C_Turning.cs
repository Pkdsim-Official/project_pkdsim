using Project_Pkdsim.ANIMATOR.Npcs.Cinderace.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.ANIMATOR.Npcs.Cinderace.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Cinderace.movementbasedanimations.Turning
{
	public class C_Turning : MonoBehaviour	
	{
		private C_TurnLeft C_turnleft;
		private C_TurnRight C_turnright;

		public void C_TurningController()
		{
			if (C_turnleft == null)
			{
				Load_C_turnLeft();
			}
			if (C_turnright == null)
			{
				Load_C_turnRight();
			}
		}

		private void Load_C_turnRight()
		{
			C_turnright.C_TurnRightController();
		}
		
		private void Load_C_turnLeft()
		{
			C_turnleft.C_TurnLeftController();
		}
	}
}