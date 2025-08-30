using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Beedrill.movementbasedanimations.Turning
{
	public class BE_Turning : MonoBehaviour	
	{
		private BE_TurnLeft BE_turnleft;
		private BE_TurnRight BE_turnright;

		public void BE_TurningController()
		{
			if (BE_turnleft == null)
			{
				Load_BE_turnLeft();
			}
			if (BE_turnright == null)
			{
				Load_BE_turnRight();
			}
		}

		private void Load_BE_turnRight()
		{
			BE_turnright.BE_TurnRightController();
		}
		
		private void Load_BE_turnLeft()
		{
			BE_turnleft.BE_TurnLeftController();
		}
	}
}