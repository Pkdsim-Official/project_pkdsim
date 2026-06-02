using project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations
{
	public class PheromosaParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private PHParent_Jumping PheromosaParentMom_MBA_Jumping;
		
		private PHParent_Running PheromosaParentMom_MBA_Running;


		private PHParent_Turning PheromosaParentMom_MBA_Turning;

		private PHParent_Strafing PheromosaParentMom_MBA_Strafe;

		public void PHMovementAnimatorController()
		{
			PheromosaParentMom_MBA_Running.PHParent_RunningController();

			PheromosaParentMom_MBA_Jumping.PHParent_JumpingController();

			PheromosaParentMom_MBA_Turning.PHParent_TurningController();	

			PheromosaParentMom_MBA_Strafe.PHParent_StrafingController();
		}
	}
}