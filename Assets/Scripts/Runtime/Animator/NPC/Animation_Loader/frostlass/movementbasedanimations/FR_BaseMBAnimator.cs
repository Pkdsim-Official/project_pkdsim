using Project_Pkdsim.ANIMATOR.Npcs.Frostlass.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Npcs.Frostlass.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Npcs.Frostlass.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Npcs.Frostlass.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Frostlass.movementbasedanimations
{
	public class Frostlass_MovementAnimatorController : MonoBehaviour 
	{
		private FR_Jumping Frostlass_MBA_Jumping;
		
		private FR_Running Frostlass_MBA_Running;


		private FR_Turning Frostlass_MBA_Turning;

		private FR_Strafing Frostlass_MBA_Strafe;

		public void FRMovementAnimatorController()
		{
			Frostlass_MBA_Running.FR_RunningController();

			Frostlass_MBA_Jumping.FR_JumpingController();

			Frostlass_MBA_Turning.FR_TurningController();	

			Frostlass_MBA_Strafe.FR_StrafingController();
		}
	}
}