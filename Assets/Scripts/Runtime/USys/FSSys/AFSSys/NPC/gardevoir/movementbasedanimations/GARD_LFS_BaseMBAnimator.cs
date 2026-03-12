using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.movementbasedanimations.Jumping;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.movementbasedanimations.Running;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.movementbasedanimations.Strafing;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.movementbasedanimations
{
	public class Gardevoir_LFS_MovementAnimatorController : MonoBehaviour 
	{
		private GARD_LFS_Jumping Gardevoir_MBA_Jumping;
		
		private GARD_LFS_Running Gardevoir_MBA_Running;


		private GARD_LFS_Turning Gardevoir_MBA_Turning;

		private GARD_LFS_Strafing Gardevoir_MBA_Strafe;

		public void GARD_LFS_MovementAnimatorController()
		{
			Gardevoir_MBA_Running.GARD_LFS_RunningController();

			Gardevoir_MBA_Jumping.GARD_LFS_JumpingController();

			Gardevoir_MBA_Turning.GARD_LFS_TurningController();	

			Gardevoir_MBA_Strafe.GARD_LFS_StrafingController();
		}
	}
}