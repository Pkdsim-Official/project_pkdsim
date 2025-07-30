using project_pkdsim.ANIMATOR.Npcs.Pheromosa.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Npcs.Pheromosa.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Npcs.Pheromosa.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Npcs.Pheromosa.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Pheromosa.movementbasedanimations
{
	public class Pheromosa_MovementAnimatorController : MonoBehaviour 
	{
		private PH_Jumping Pheromosa_MBA_Jumping;
		
		private PH_Running Pheromosa_MBA_Running;


		private PH_Turning Pheromosa_MBA_Turning;

		private PH_Strafing Pheromosa_MBA_Strafe;

		public void PHMovementAnimatorController()
		{
			Pheromosa_MBA_Running.PH_RunningController();

			Pheromosa_MBA_Jumping.PH_JumpingController();

			Pheromosa_MBA_Turning.PH_TurningController();	

			Pheromosa_MBA_Strafe.PH_StrafingController();
		}
	}
}