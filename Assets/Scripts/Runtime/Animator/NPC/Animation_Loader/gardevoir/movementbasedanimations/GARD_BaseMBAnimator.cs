using Project_Pkdsim.ANIMATOR.Npcs.Gardevoir.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Npcs.Gardevoir.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Npcs.Gardevoir.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Npcs.Gardevoir.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Gardevoir.movementbasedanimations
{
	public class Gardevoir_MovementAnimatorController : MonoBehaviour 
	{
		private GARD_Jumping Gardevoir_MBA_Jumping;
		
		private GARD_Running Gardevoir_MBA_Running;


		private GARD_Turning Gardevoir_MBA_Turning;

		private GARD_Strafing Gardevoir_MBA_Strafe;

		public void GARDMovementAnimatorController()
		{
			Gardevoir_MBA_Running.GARD_RunningController();

			Gardevoir_MBA_Jumping.GARD_JumpingController();

			Gardevoir_MBA_Turning.GARD_TurningController();	

			Gardevoir_MBA_Strafe.GARD_StrafingController();
		}
	}
}