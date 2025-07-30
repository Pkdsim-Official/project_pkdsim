using project_pkdsim.ANIMATOR.Parents.Pheromosa.Dad.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.Dad.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.Dad.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Pheromosa.Dad.movementbasedanimations
{
	public class PheromosaParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private PHParentDad_Jumping PheromosaParentDad_MBA_Jumping;

		private PHParentDad_Running PheromosaParentDad_MBA_Running;

		private PHParentDad_Turning PheromosaParentDad_MBA_Turning;

		private PHParentDad_Strafing PheromosaParentDad_MBA_Strafe;

		public void PHParentDad_MovementAnimatorController()
		{
			PheromosaParentDad_MBA_Running.PHParentDad_RunningController();

			PheromosaParentDad_MBA_Jumping.PHParentDad_JumpingController();

			PheromosaParentDad_MBA_Turning.PHParentDad_TurningController();	

			PheromosaParentDad_MBA_Strafe.PHParentDad_StrafingController();
		}
	}
}