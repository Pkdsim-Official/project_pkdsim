using project_pkdsim.ANIMATOR.Parents.Delphox.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Delphox.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Delphox.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Delphox.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Delphox.movementbasedanimations
{
	public class DelphoxParent_AnimatorBaseMovementController : MonoBehaviour 
	{
		private DLParent_Jumping DL_MBA_Jumping;
		
		private DLParent_Running DL_MBA_Running;


		private DLParent_Turning DL_MBA_Turning;

		private DLParent_Strafing DL_MBA_Strafe;

		public void DLMovementAnimatorController()
		{
			DL_MBA_Running.DLParent_RunningController();

			DL_MBA_Jumping.DLParent_JumpingController();

			DL_MBA_Turning.DLParent_TurningController();	

			DL_MBA_Strafe.DLParent_StrafingController();
		}
	}
}