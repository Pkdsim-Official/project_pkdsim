using project_pkdsim.ANIMATOR.Npcs.Tsareena.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Npcs.Tsareena.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Npcs.Tsareena.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Npcs.Tsareena.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Tsareena.movementbasedanimations
{
	public class Tsareena_MovementAnimatorController : MonoBehaviour 
	{
		private T_Jumping Tsareena_MBA_Jumping;
		
		private T_Running Tsareena_MBA_Running;


		private T_Turning Tsareena_MBA_Turning;

		private T_Strafing Tsareena_MBA_Strafe;

		public void T_MovementAnimatorController()
		{
			Tsareena_MBA_Running.T_RunningController();

			Tsareena_MBA_Jumping.T_JumpingController();

			Tsareena_MBA_Turning.T_TurningController();	

			Tsareena_MBA_Strafe.T_StrafingController();
		}
	}
}