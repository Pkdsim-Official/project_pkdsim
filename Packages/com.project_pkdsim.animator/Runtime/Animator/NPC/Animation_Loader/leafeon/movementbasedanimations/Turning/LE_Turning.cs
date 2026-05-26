using project_pkdsim.ANIMATOR.NPC.Leafeon.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.NPC.Leafeon.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Leafeon.movementbasedanimations.Turning
{
	public class LE_Turning : MonoBehaviour	
	{
		private LE_TurnLeft LE_turnleft;
		private LE_TurnRight LE_turnright;

		public void LE_TurningController()
		{
			if (LE_turnleft == null)
			{
				Load_LE_turnLeft();
			}
			if (LE_turnright == null)
			{
				Load_LE_turnRight();
			}
		}

		private void Load_LE_turnRight()
		{
			LE_turnright.LE_TurnRightController();
		}
		
		private void Load_LE_turnLeft()
		{
			LE_turnleft.LE_TurnLeftController();
		}
	}
}