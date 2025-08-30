using project_pkdsim.Models.ANIMATOR.NPC.Frostlass.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Frostlass.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Frostlass.movementbasedanimations.Turning
{
	public class FR_Turning : MonoBehaviour	
	{
		private FR_TurnLeft FR_turnleft;
		private FR_TurnRight FR_turnright;

		public void FR_TurningController()
		{
			if (FR_turnleft == null)
			{
				Load_FR_turnLeft();
			}
			if (FR_turnright == null)
			{
				Load_FR_turnRight();
			}
		}
		
		private void Load_FR_turnRight()
		{
			FR_turnright.FR_TurnRightController();
		}
		
		private void Load_FR_turnLeft()
		{
			FR_turnleft.FR_TurnLeftController();
		}
	}
}