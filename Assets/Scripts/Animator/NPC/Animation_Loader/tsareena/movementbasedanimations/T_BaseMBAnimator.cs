using project_pkdsim.Models.ANIMATOR.NPC.Tsareena.movementbasedanimations.Jumping;
using project_pkdsim.Models.ANIMATOR.NPC.Tsareena.movementbasedanimations.Running;
using project_pkdsim.Models.ANIMATOR.NPC.Tsareena.movementbasedanimations.Strafe;
using project_pkdsim.Models.ANIMATOR.NPC.Tsareena.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Tsareena.movementbasedanimations
{
	public class Tsareena_AnimatorBaseMovementController : MonoBehaviour 
	{
		private T_Jumping Tsareena_MBA_Jumping;
		
		private T_Running Tsareena_MBA_Running;


		private T_Turning Tsareena_MBA_Turning;

		private T_Strafing Tsareena_MBA_Strafe;

		public void TMovementAnimatorController()
		{
			Tsareena_MBA_Running.T_RunningController();

			Tsareena_MBA_Jumping.T_JumpingController();

			Tsareena_MBA_Turning.T_TurningController();	

			Tsareena_MBA_Strafe.T_StrafingController();
		}
	}
}