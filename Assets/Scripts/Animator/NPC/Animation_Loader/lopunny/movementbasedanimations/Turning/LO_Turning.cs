using project_pkdsim.Models.ANIMATOR.NPC.Lopunny.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Models.ANIMATOR.NPC.Lopunny.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Lopunny.movementbasedanimations.Turning
{
	public class LO_Turning : MonoBehaviour	
	{
		private LO_TurnLeft LO_turnleft;
		private LO_TurnRight LO_turnright;

		public void LO_TurningController()
		{
			if (LO_turnleft == null)
			{
				Load_LO_turnLeft();
			}

			if (LO_turnright == null)
			{
				Load_LO_turnRight();
			}
			
		}
		private void Load_LO_turnRight()
		{
			LO_turnright.LO_TurnRightController();
		}
		
		private void Load_LO_turnLeft()
		{
			LO_turnleft.LO_TurnLeftController();
		}
	}
}