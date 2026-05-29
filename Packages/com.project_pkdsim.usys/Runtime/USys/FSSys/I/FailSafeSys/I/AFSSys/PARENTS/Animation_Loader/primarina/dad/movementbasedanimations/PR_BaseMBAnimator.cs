using project_pkdsim.ANIMATOR.Parents.Primarina.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Primarina.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Primarina.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Primarina.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Primarina.movementbasedanimations
{
	public class PrimarinaParent_AnimatorMovementController : MonoBehaviour 
	{
		private PRParent_Jumping Primarina_MBA_Jumping;
		
		private PRParent_Running Primarina_MBA_Running;


		private PRParent_Turning Primarina_MBA_Turning;

		private PRParent_Strafing Primarina_MBA_Strafe;

		public void PRMovementAnimatorController()
		{
			Primarina_MBA_Running.PRParent_RunningController();

			Primarina_MBA_Jumping.PRParent_JumpingController();

			Primarina_MBA_Turning.PRParent_TurningController();	

			Primarina_MBA_Strafe.PRParent_StrafingController();
		}
	}
}