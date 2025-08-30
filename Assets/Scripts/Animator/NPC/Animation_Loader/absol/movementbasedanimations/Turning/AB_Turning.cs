using project_pkdsim.Models.ANIMATOR.NPC.Absol.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Absol.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Absol.movementbasedanimations.Turning
{
	public class AB_Turning : MonoBehaviour	
	{
		private AB_TurnLeft AB_turnleft;
		private AB_TurnRight AB_turnright;

		public void AB_TurningController()
		{
			if (AB_turnleft == null)
			{
				Load_AB_turnLeft();
			}
			if (AB_turnright == null)
			{
				Load_AB_turnRight();
			}
		}

		private void Load_AB_turnRight()
		{
			AB_turnright.AB_TurnRightController();
		}
		
		private void Load_AB_turnLeft()
		{
			AB_turnleft.AB_TurnLeftController();
		}
	}
}