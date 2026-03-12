using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.movementbasedanimations.Jumping;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.movementbasedanimations.Running;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.movementbasedanimations.Strafing;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.movementbasedanimations
{
	public class Meowscarada_LFS_MovementAnimatorController : MonoBehaviour 
	{
		private MEOW_LFS_Jumping Meowscarada_MBA_Jumping;
		
		private MEOW_LFS_Running Meowscarada_MBA_Running;


		private MEOW_LFS_Turning Meowscarada_MBA_Turning;

		private MEOW_LFS_Strafing Meowscarada_MBA_Strafe;

		public void MEOW_LFS_MovementAnimatorController()
		{
			Meowscarada_MBA_Running.MEOW_LFS_RunningController();

			Meowscarada_MBA_Jumping.MEOW_LFS_JumpingController();

			Meowscarada_MBA_Turning.MEOW_LFS_TurningController();	

			Meowscarada_MBA_Strafe.MEOW_LFS_StrafingController();
		}
	}
}