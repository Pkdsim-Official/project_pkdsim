using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.movementbasedanimations.Turning
{
	public class T_LFS_Turning : MonoBehaviour	
	{
		private T_LFS_TurnLeft T_LFS_turnleft;
		private T_LFS_TurnRight T_LFS_turnright;

		public void T_LFS_TurningController()
		{
			if (T_LFS_turnleft != null)
			{
				Load_T_turnLeft();
			}

			if (T_LFS_turnright != null)
			{
				Load_T_turnRight();
			}
		}
		private void Load_T_turnRight()
		{
			T_LFS_turnright.T_LFS_TurnRightController();
		}
		
		private void Load_T_turnLeft()
		{
			T_LFS_turnleft.T_LFS_TurnLeftController();
		}
	}
}