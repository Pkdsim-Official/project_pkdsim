using project_pkdsim.ANIMATOR.Npcs.Delphox.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.ANIMATOR.Npcs.Delphox.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Delphox.movementbasedanimations.Turning
{
	public class DL_Turning : MonoBehaviour	
	{
		private DL_TurnLeft DL_turnleft;
		private DL_TurnRight DL_turnright;

		public void DL_TurningController()
		{
			if (DL_turnleft == null)
			{
				Load_DL_turnLeft();
			}
			if (DL_turnright == null)
			{
				Load_DL_turnRight();
			}
			

		}
		private void Load_DL_turnRight()
		{
			DL_turnright.DL_TurnRightController();
		}
		
		private void Load_DL_turnLeft()
		{
			DL_turnleft.DL_TurnLeftController();
		}
	}
}