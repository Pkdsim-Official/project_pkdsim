using project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Blaziken.Mom.movementbasedanimations
{
	public class BlazikenParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private BLParent_Jumping BL_MBA_Jumping;
		
		private BLParent_Running BL_MBA_Running;


		private BLParent_Turning BL_MBA_Turning;

		private BLParent_Strafing BL_MBA_Strafe;

		public void BLMovementAnimatorController()
		{
			BL_MBA_Running.BLParent_RunningController();

			BL_MBA_Jumping.BLParent_JumpingController();

			BL_MBA_Turning.BLParent_TurningController();	

			BL_MBA_Strafe.BLParent_StrafingController();
		}
	}
}