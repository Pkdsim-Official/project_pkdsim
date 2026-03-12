using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.movementbasedanimations.Turning.TurnLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.movementbasedanimations.Turning
{
	public class DL_LFS_Turning : MonoBehaviour	
	{
		DL_LFS_TurnLeft DL_LFS_turnleft;
		DL_LFS_TurnRight DL_LFS_turnright;

		public void DL_LFS_TurningController()
		{
			if (DL_LFS_turnleft == null)
			{
				DL_LFS_turnleft = GetComponent<DL_LFS_TurnLeft>();
				Load_DL_turnLeft();
			}
			if (DL_LFS_turnright == null)
			{
				DL_LFS_turnright = GetComponent<DL_LFS_TurnRight>();
				Load_DL_turnRight();
			}
			

		}
		private void Load_DL_turnRight()
		{
			DL_LFS_turnright.DL_LFS_TurnRightController();
		}
		
		private void Load_DL_turnLeft()
		{
			DL_LFS_turnleft.DL_LFS_TurnLeftController();
		}
	}
}