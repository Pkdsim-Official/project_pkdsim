using Project_Pkdsim.ANIMATOR.Npcs.Primarina.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Npcs.Primarina.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Npcs.Primarina.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Npcs.Primarina.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Primarina.movementbasedanimations
{
	public class Primarina_MovementAnimatorController : MonoBehaviour 
	{
		private PR_Jumping Primarina_MBA_Jumping;
		
		private PR_Running Primarina_MBA_Running;


		private PR_Turning Primarina_MBA_Turning;

		private PR_Strafing Primarina_MBA_Strafe;

		public void PRMovementAnimatorController()
		{
			Primarina_MBA_Running.PR_RunningController();

			Primarina_MBA_Jumping.PR_JumpingController();

			Primarina_MBA_Turning.PR_TurningController();	

			Primarina_MBA_Strafe.PR_StrafingController();
		}
	}
}