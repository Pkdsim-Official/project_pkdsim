using project_pkdsim.ANIMATOR.NPC.Braixen.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.NPC.Braixen.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.NPC.Braixen.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.NPC.Braixen.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Braixen.movementbasedanimations
{
	public class Braixen_AnimatorMovementController : MonoBehaviour 
	{
		private BR_Jumping BR_MBA_Jumping;
		
		private BR_Running BR_MBA_Running;


		private BR_Turning BR_MBA_Turning;

		private BR_Strafing BR_MBA_Strafe;

		public void BRMovementAnimatorController()
		{
			BR_MBA_Running.BR_RunningController();

			BR_MBA_Jumping.BR_JumpingController();

			BR_MBA_Turning.BR_TurningController();	

			BR_MBA_Strafe.BR_StrafingController();
		}
	}
}