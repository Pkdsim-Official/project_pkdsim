using project_pkdsim.Models.ANIMATOR.NPC.Jolteon.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Jolteon.movementbasedanimations.Turning.TurnRight;

using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Jolteon.movementbasedanimations.Turning
{
	public class JT_Turning : MonoBehaviour	
	{
		private JT_TurnLeft JT_turnleft;
		private JT_TurnRight JT_turnright;

		public void JT_TurningController()
		{
			if (JT_turnleft == null)
			{
				Load_JT_turnLeft();
			}
			if (JT_turnright == null)
			{
				Load_JT_turnRight();
			}
		}

		private void Load_JT_turnRight()
		{
			JT_turnright.JT_TurnRightController();
		}
		
		private void Load_JT_turnLeft()
		{
			JT_turnleft.JT_TurnLeftController();
		}
	}
}