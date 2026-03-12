using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.movementbasedanimations.Turning
{
	public class LUCA_LFS_Turning : MonoBehaviour	
	{
		LUCA_LFS_TurnLeft LUCA_LFS_turnleft;
		LUCA_LFS_TurnRight LUCA_LFS_turnright;

		public void LUCA_LFS_TurningController()
		{
			if (LUCA_LFS_turnleft != null)
			{
				Load_LUCA_turnLeft();
			}

			if (LUCA_LFS_turnright != null)
			{
				Load_LUCA_turnRight();
			}
			
		}
		private void Load_LUCA_turnRight()
		{
			LUCA_LFS_turnright.LUCA_LFS_TurnRightController();
		}
		
		private void Load_LUCA_turnLeft()
		{
			LUCA_LFS_turnleft.LUCA_LFS_TurnLeftController();
		}
	}
}