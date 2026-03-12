using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.movementbasedanimations.Jumping;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.movementbasedanimations.Running;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.movementbasedanimations.Strafing;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.movementbasedanimations
{
	public class Flareon_LFS_MovementAnimatorController : MonoBehaviour 
	{
		private FL_LFS_Jumping Flareon_MBA_Jumping;
		
		private FL_LFS_Running Flareon_MBA_Running;


		private FL_LFS_Turning Flareon_MBA_Turning;

		private FL_LFS_Strafing Flareon_MBA_Strafe;

		public void FL_LFS_MovementAnimatorController()
		{
			Flareon_MBA_Running.FL_LFS_RunningController();

			Flareon_MBA_Jumping.FL_LFS_JumpingController();

			Flareon_MBA_Turning.FL_LFS_TurningController();	

			Flareon_MBA_Strafe.FL_LFS_StrafingController();
		}
	}
}