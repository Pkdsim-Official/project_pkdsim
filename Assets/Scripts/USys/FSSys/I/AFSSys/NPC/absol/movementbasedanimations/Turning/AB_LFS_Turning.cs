using project_pkdsim.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.movementbasedanimations.Turning
{
	public class AB_LFS_Turning : MonoBehaviour	
	{
		AB_LFS_TurnLeft AB_LFS_turnleft;
		AB_LFS_TurnRight AB_LFS_turnright;

		public void AB_LFS_TurningController()
		{
			if (AB_LFS_turnleft == null)
			{
				AB_LFS_turnleft = GetComponent<AB_LFS_TurnLeft>();
				Load_AB_turnLeft();
			}
			if (AB_LFS_turnright == null)
			{
				AB_LFS_turnright = GetComponent<AB_LFS_TurnRight>();
				Load_AB_turnRight();
			}
			

		}
		private void Load_AB_turnRight()
		{
			AB_LFS_turnright.AB_LFS_TurnRightController();
		}
		
		private void Load_AB_turnLeft()
		{
			AB_LFS_turnleft.AB_LFS_TurnLeftController();
		}
	}
}