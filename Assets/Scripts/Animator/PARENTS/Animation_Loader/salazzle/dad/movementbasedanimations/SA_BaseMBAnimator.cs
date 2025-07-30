using project_pkdsim.ANIMATOR.Parents.Salazzle.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Salazzle.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Salazzle.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Salazzle.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Salazzle.movementbasedanimations
{
	public class SalazzleParent_AnimatorBaseMovementController : MonoBehaviour 
	{
		private SAParent_Jumping SA_MBA_Jumping;
		
		private SAParent_Running SA_MBA_Running;


		private SAParent_Turning SA_MBA_Turning;

		private SAParent_Strafing SA_MBA_Strafe;

		public void SA_MovementAnimatorController()
		{
			SA_MBA_Running.SAParent_RunningController();

			SA_MBA_Jumping.SAParent_JumpingController();

			SA_MBA_Turning.SAParent_TurningController();	

			SA_MBA_Strafe.SAParent_StrafingController();
		}
	}
}