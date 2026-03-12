using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.movementbasedanimations.Turning
{
	public class NOI_LFS_Turning : MonoBehaviour	
	{
		NOI_LFS_TurnLeft NOI_LFS_turnleft;
		NOI_LFS_TurnRight NOI_LFS_turnright;

		public void NOI_LFS_TurningController()
		{
			if (NOI_LFS_turnleft == null)
			{
				Load_NOI_turnLeft();
			}

			if (NOI_LFS_turnright == null)
			{
				Load_NOI_turnRight();
			}
			
		}
		private void Load_NOI_turnRight()
		{
			NOI_LFS_turnright.NOI_LFS_TurnRightController();
		}
		
		private void Load_NOI_turnLeft()
		{
			NOI_LFS_turnleft.NOI_LFS_TurnLeftController();
		}
	}
}