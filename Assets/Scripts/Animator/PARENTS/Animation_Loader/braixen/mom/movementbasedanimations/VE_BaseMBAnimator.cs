using project_pkdsim.ANIMATOR.Parents.Braixen.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Braixen.Mom.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Braixen.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Braixen.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Braixen.Mom.movementbasedanimations
{
	public class BraixenParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private BRParentMom_Jumping BR_MBA_Jumping;
		
		private BRParentMom_Running BR_MBA_Running;


		private BRParentMom_Turning BR_MBA_Turning;

		private BRParentMom_Strafing BR_MBA_Strafe;

		public void BRParentMom_MovementAnimatorController()
		{
			BR_MBA_Running.BRParentMom_RunningController();

			BR_MBA_Jumping.BRParentMom_JumpingController();

			BR_MBA_Turning.BRParentMom_TurningController();	

			BR_MBA_Strafe.BRParentMom_StrafingController();
		}
	}
}