using project_pkdsim.ANIMATOR.Parents.Tsareena.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Tsareena.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Tsareena.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Tsareena.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.movementbasedanimations
{
	public class TsareenaParent_AnimatorBaseMovementController : MonoBehaviour 
	{
		private TParent_Jumping Tsareena_MBA_Jumping;
		
		private TParent_Running Tsareena_MBA_Running;


		private TParent_Turning Tsareena_MBA_Turning;

		private TParent_Strafing Tsareena_MBA_Strafe;

		public void TMovementAnimatorController()
		{
			Tsareena_MBA_Running.TParent_RunningController();

			Tsareena_MBA_Jumping.TParent_JumpingController();

			Tsareena_MBA_Turning.TParent_TurningController();	

			Tsareena_MBA_Strafe.TParent_StrafingController();
		}
	}
}