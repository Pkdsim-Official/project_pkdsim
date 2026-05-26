using project_pkdsim.ANIMATOR.Parents.Pheromosa.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Pheromosa.movementbasedanimations
{
	public class PheromosaParent_AnimatorBaseMovementController : MonoBehaviour 
	{
		private PHParent_Jumping Pheromosa_MBA_Jumping;
		
		private PHParent_Running Pheromosa_MBA_Running;


		private PHParent_Turning Pheromosa_MBA_Turning;

		private PHParent_Strafing Pheromosa_MBA_Strafe;

		public void PHMovementAnimatorController()
		{
			Pheromosa_MBA_Running.PHParent_RunningController();

			Pheromosa_MBA_Jumping.PHParent_JumpingController();

			Pheromosa_MBA_Turning.PHParent_TurningController();	

			Pheromosa_MBA_Strafe.PHParent_StrafingController();
		}
	}
}