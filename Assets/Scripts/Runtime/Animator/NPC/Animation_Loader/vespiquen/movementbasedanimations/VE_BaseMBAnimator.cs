using Project_Pkdsim.ANIMATOR.Npcs.Vespiquen.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Npcs.Vespiquen.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Npcs.Vespiquen.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Npcs.Vespiquen.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Vespiquen.movementbasedanimations
{
	public class Vespiquen_MovementAnimatorController : MonoBehaviour 
	{
		private VE_Jumping VE_MBA_Jumping;
		
		private VE_Running VE_MBA_Running;


		private VE_Turning VE_MBA_Turning;

		private VE_Strafing VE_MBA_Strafe;

		public void VEMovementAnimatorController()
		{
			VE_MBA_Running.VE_RunningController();

			VE_MBA_Jumping.VE_JumpingController();

			VE_MBA_Turning.VE_TurningController();	

			VE_MBA_Strafe.VE_StrafingController();
		}
	}
}