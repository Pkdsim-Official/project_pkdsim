using project_pkdsim.ANIMATOR.NPC.Zoroark.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.NPC.Zoroark.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Zoroark.movementbasedanimations.Turning
{
	public class Z_Turning : MonoBehaviour	
	{
		private Z_TurnLeft Z_turnleft;
		private Z_TurnRight Z_turnright;

		public void Z_TurningController()
		{
			if (Z_turnleft != null)
			{
				Load_Z_turnLeft();
			}
			
			if (Z_turnright != null)
			{
				Load_Z_turnRight();
			}
		}
		private void Load_Z_turnRight()
		{
			Z_turnright.Z_TurnRightController();
		}
		
		private void Load_Z_turnLeft()
		{
			Z_turnleft.Z_TurnLeftController();
		}
	}
}