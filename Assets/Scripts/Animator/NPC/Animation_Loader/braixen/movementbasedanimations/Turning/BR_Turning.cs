using project_pkdsim.Models.ANIMATOR.NPC.Braixen.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Braixen.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Braixen.movementbasedanimations.Turning
{
	public class BR_Turning : MonoBehaviour	
	{
		BR_TurnLeft BR_turnleft;
		BR_TurnRight BR_turnright;

		public void BR_TurningController()
		{
			if (BR_turnleft == null)
			{
				Load_BR_turnLeft();
			}
			if (BR_turnright == null)
			{
				Load_BR_turnRight();
			}
		}
		
		private void Load_BR_turnRight()
		{
			BR_turnright.BR_TurnRightController();
		}
		
		private void Load_BR_turnLeft()
		{
			BR_turnleft.BR_TurnLeftController();
		}
	}
}