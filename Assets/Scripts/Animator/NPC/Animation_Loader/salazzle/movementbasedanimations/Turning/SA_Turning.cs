using project_pkdsim.ANIMATOR.NPC.Salazzle.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.NPC.Salazzle.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Salazzle.movementbasedanimations.Turning
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