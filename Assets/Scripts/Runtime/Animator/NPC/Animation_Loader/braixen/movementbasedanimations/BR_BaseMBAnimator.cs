using Project_Pkdsim.ANIMATOR.Npcs.Braixen.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Npcs.Braixen.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Npcs.Braixen.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Npcs.Braixen.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Braixen.movementbasedanimations
{
	public class Braixen_MovementAnimatorController : MonoBehaviour 
	{
		private BR_Jumping BR_MBA_Jumping;
		
		private BR_Running BR_MBA_Running;


		private BR_Turning BR_MBA_Turning;

		private BR_Strafing BR_MBA_Strafe;

		public void BRMovementAnimatorController()
		{
			BR_MBA_Running.BR_RunningController();

			BR_MBA_Jumping.BR_JumpingController();

			BR_MBA_Turning.BR_TurningController();	

			BR_MBA_Strafe.BR_StrafingController();
		}
	}
}