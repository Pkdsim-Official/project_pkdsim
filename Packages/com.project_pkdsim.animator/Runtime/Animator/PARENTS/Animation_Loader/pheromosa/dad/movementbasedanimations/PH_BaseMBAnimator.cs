using project_pkdsim.ANIMATOR.Parents.Pheromosa.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Pheromosa.movementbasedanimations
{
	public class PheromosaParentDad_AnimatorMovementController : MonoBehaviour 
	{
		private PHParent_Jumping PheromosaParentDad_MBA_Jumping;
		
		private PHParent_Running PheromosaParentDad_MBA_Running;


		private PHParent_Turning PheromosaParentDad_MBA_Turning;

		private PHParent_Strafing PheromosaParentDad_MBA_Strafe;

		public void PHMovementAnimatorController()
		{
			PheromosaParentDad_MBA_Running.PHParent_RunningController();

			PheromosaParentDad_MBA_Jumping.PHParent_JumpingController();

			PheromosaParentDad_MBA_Turning.PHParent_TurningController();	

			PheromosaParentDad_MBA_Strafe.PHParent_StrafingController();
		}
	}
}