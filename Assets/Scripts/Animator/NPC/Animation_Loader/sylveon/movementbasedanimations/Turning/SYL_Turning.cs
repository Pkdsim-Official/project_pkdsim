using project_pkdsim.ANIMATOR.Npcs.Sylveon.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Npcs.Sylveon.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Sylveon.movementbasedanimations.Turning
{
	public class SYL_Turning : MonoBehaviour 
	{
		private SYL_TurnLeft SYL_turnleft;
		private SYL_TurnRight SYL_turnright;

		public void SYL_TurningController()
		{
			if (SYL_turnleft == null)
			{
				Load_SYL_turnLeft();
			}
			if (SYL_turnright == null)
			{
				Load_SYL_turnRight();
			}
		}

		private void Load_SYL_turnRight()
		{
			SYL_turnright.SYL_TurnRightController();
		}
		
		private void Load_SYL_turnLeft()
		{
			SYL_turnleft.SYL_TurnLeftController();
		}

	}
}