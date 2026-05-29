using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Braixen.Dad.movementbasedanimations
{
	public class BraixenParentDad_AnimatorMovementController : MonoBehaviour 
	{
		private BRParent_Jumping BR_MBA_Jumping;
		
		private BRParent_Running BR_MBA_Running;


		private BRParent_Turning BR_MBA_Turning;

		private BRParent_Strafing BR_MBA_Strafe;

		public void BRMovementAnimatorController()
		{
			BR_MBA_Running.BRParent_RunningController();

			BR_MBA_Jumping.BRParent_JumpingController();

			BR_MBA_Turning.BRParent_TurningController();	

			BR_MBA_Strafe.BRParent_StrafingController();
		}
	}
}