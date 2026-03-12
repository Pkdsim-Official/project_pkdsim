using Project_Pkdsim.ANIMATOR.Npcs.Dragapult.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Npcs.Dragapult.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Npcs.Dragapult.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Npcs.Dragapult.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Dragapult.movementbasedanimations
{
	public class Dragapult_MovementAnimatorController : MonoBehaviour 
	{
		private DR_Jumping DR_MBA_Jumping;
		
		private DR_Running DR_MBA_Running;


		private DR_Turning DR_MBA_Turning;

		private DR_Strafing DR_MBA_Strafe;

		public void DRMovementAnimatorController()
		{
			DR_MBA_Running.DR_RunningController();

			DR_MBA_Jumping.DR_JumpingController();

			DR_MBA_Turning.DR_TurningController();	

			DR_MBA_Strafe.DR_StrafingController();
		}
	}
}