using project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations
{
	public class PheromosaParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private PHParentMom_Jumping PH_MBA_Jumping;
		
		private PHParentMom_Running PH_MBA_Running;


		private PHParentMom_Turning PH_MBA_Turning;

		private PHParentMom_Strafing PH_MBA_Strafe;

		public void PHParentMom_MovementAnimatorController()
		{
			PH_MBA_Running.PHParentMom_RunningController();

			PH_MBA_Jumping.PHParentMom_JumpingController();

			PH_MBA_Turning.PHParentMom_TurningController();	

			PH_MBA_Strafe.PHParentMom_StrafingController();
		}
	}
}