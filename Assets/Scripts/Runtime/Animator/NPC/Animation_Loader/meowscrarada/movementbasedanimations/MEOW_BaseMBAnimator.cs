using Project_Pkdsim.ANIMATOR.Npcs.Meowscarada.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Npcs.Meowscarada.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Npcs.Meowscarada.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Npcs.Meowscarada.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Meowscarada.movementbasedanimations
{
	public class Meowscarada_MovementAnimatorController : MonoBehaviour 
	{
		private MEOW_Jumping Meowscarada_MBA_Jumping;
		
		private MEOW_Running Meowscarada_MBA_Running;


		private MEOW_Turning Meowscarada_MBA_Turning;

		private MEOW_Strafing Meowscarada_MBA_Strafe;

		public void MEOWMovementAnimatorController()
		{
			Meowscarada_MBA_Running.MEOW_RunningController();

			Meowscarada_MBA_Jumping.MEOW_JumpingController();

			Meowscarada_MBA_Turning.MEOW_TurningController();	

			Meowscarada_MBA_Strafe.MEOW_StrafingController();
		}
	}
}