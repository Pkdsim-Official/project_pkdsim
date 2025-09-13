using project_pkdsim.ANIMATOR.NPC.Flareon.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.NPC.Flareon.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.NPC.Flareon.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.NPC.Flareon.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Flareon.movementbasedanimations
{
	public class Flareon_AnimatorBaseMovementController : MonoBehaviour 
	{
		private FL_Jumping FL_MBA_Jumping;
		
		private FL_Running FL_MBA_Running;

		private FL_Turning FL_MBA_Turning;

		private FL_Strafing FL_MBA_Strafe;

		private void FL_Base_IdleAnimatorController()
		{
			FL_MBA_Running.FL_RunningController();

			FL_MBA_Jumping.FL_JumpingController();

			FL_MBA_Turning.FL_TurningController();	

			FL_MBA_Strafe.FL_StrafingController();
		}
	}
}