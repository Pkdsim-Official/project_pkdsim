using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.movementbasedanimations.Jumping;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.movementbasedanimations.Running;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.movementbasedanimations.Strafing;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.movementbasedanimations
{
	public class Lunala_LFS_MovementAnimatorController : MonoBehaviour 
	{
		private LUNA_LFS_Jumping Lunala_MBA_Jumping;
		
		private LUNA_LFS_Running Lunala_MBA_Running;


		private LUNA_LFS_Turning Lunala_MBA_Turning;

		private LUNA_LFS_Strafing Lunala_MBA_Strafe;

		public void LUNA_LFS_MovementAnimatorController()
		{
			Lunala_MBA_Running.LUNA_LFS_RunningController();

			Lunala_MBA_Jumping.LUNA_LFS_JumpingController();

			Lunala_MBA_Turning.LUNA_LFS_TurningController();	

			Lunala_MBA_Strafe.LUNA_LFS_StrafingController();
		}
	}
}