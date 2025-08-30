using project_pkdsim.Models.ANIMATOR.NPC.Garchomp.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Garchomp.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Garchomp.movementbasedanimations.Turning
{
	public class GARC_Turning : MonoBehaviour	
	{
		private GARC_TurnLeft GARC_turnleft;
		private GARC_TurnRight GARC_turnright;

		public void GARC_TurningController()
		{
			if (GARC_turnleft == null)
			{
				Load_GARC_turnLeft();
			}
			if (GARC_turnright == null)
			{
				Load_GARC_turnRight();
			}
		}

		private void Load_GARC_turnRight()
		{
			GARC_turnright.GARC_TurnRightController();
		}
		
		private void Load_GARC_turnLeft()
		{
			GARC_turnleft.GARC_TurnLeftController();
		}
	}
}