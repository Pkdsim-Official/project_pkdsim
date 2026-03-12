using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.movementbasedanimations.Turning
{
	public class BR_LFS_Turning : MonoBehaviour	
	{
		private BR_LFS_TurnLeft BR_LFS_turnleft;
		private BR_LFS_TurnRight BR_LFS_turnright;

		public void BR_LFS_TurningController()
		{
			if (BR_LFS_turnleft == null)
			{
				Load_BR_turnLeft();
			}
			if (BR_LFS_turnright == null)
			{
				Load_BR_turnRight();
			}
			

		}
		private void Load_BR_turnRight()
		{
			BR_LFS_turnright.BR_LFS_TurnRightController();
		}
		
		private void Load_BR_turnLeft()
		{
			BR_LFS_turnleft.BR_LFS_TurnLeftController();
		}
	}
}