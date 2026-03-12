using Project_Pkdsim.ANIMATOR.Npcs.Tsareena.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Npcs.Tsareena.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Npcs.Tsareena.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Npcs.Tsareena.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Tsareena.movementbasedanimations
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