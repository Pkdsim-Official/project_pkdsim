using Project_Pkdsim.ANIMATOR.Npcs.Blaziken.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Npcs.Blaziken.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Npcs.Blaziken.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Npcs.Blaziken.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Blaziken.movementbasedanimations
{
	public class Blaziken_MovementAnimatorController : MonoBehaviour 
	{
		private BL_Jumping BL_MBA_Jumping;
		
		private BL_Running BL_MBA_Running;


		private BL_Turning BL_MBA_Turning;

		private BL_Strafing BL_MBA_Strafe;

		public void BLMovementAnimatorController()
		{
			BL_MBA_Running.BL_RunningController();

			BL_MBA_Jumping.BL_JumpingController();

			BL_MBA_Turning.BL_TurningController();	

			BL_MBA_Strafe.BL_StrafingController();
		}
	}
}