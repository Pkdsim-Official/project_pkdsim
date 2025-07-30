using project_pkdsim.ANIMATOR.Parents.Delphox.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Delphox.Mom.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Delphox.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Delphox.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Delphox.Mom.movementbasedanimations
{
	public class DelphoxParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private DLParentMom_Jumping DL_MBA_Jumping;
		
		private DLParentMom_Running DL_MBA_Running;


		private DLParentMom_Turning DL_MBA_Turning;

		private DLParentMom_Strafing DL_MBA_Strafe;

		public void DLParentMom_MovementAnimatorController()
		{
			DL_MBA_Running.DLParentMom_RunningController();

			DL_MBA_Jumping.DLParentMom_JumpingController();

			DL_MBA_Turning.DLParentMom_TurningController();	

			DL_MBA_Strafe.DLParentMom_StrafingController();
		}
	}
}