using Project_Pkdsim.ANIMATOR.Npcs.Salazzle.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.ANIMATOR.Npcs.Salazzle.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Salazzle.movementbasedanimations.Turning
{
	public class SA_Turning : MonoBehaviour	
	{
		private SA_TurnLeft SA_turnleft;
		private SA_TurnRight SA_turnright;

		public void SA_TurningController()
		{
			if (SA_turnleft != null)
			{
				Load_T_turnLeft();
			}

			if (SA_turnright != null)
			{
				Load_T_turnRight();
			}
		}
		private void Load_T_turnRight()
		{
			SA_turnright.SA_TurnRightController();
		}
		
		private void Load_T_turnLeft()
		{
			SA_turnleft.SA_TurnLeftController();
		}
	}
}