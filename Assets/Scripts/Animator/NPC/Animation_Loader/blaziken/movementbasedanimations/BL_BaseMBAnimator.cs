using project_pkdsim.ANIMATOR.NPC.Blaziken.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.NPC.Blaziken.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.NPC.Blaziken.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.NPC.Blaziken.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Blaziken.movementbasedanimations
{
	public class Blaziken_AnimatorBaseMovementController : MonoBehaviour 
	{
		private BL_Jumping BL_MBA_Jumping;
		
		private BL_Running BL_MBA_Running;


		private BL_Turning BL_MBA_Turning;

		private BL_Strafing BL_MBA_Strafe;

		public void BLMovementAnimatorController()
		{
			BL_MBA_Running.BL_RunningController();

			BL_MBA_Jumping.BL_JumpingController();

			BL_MBA_Turning.BL_TurningController();	

			BL_MBA_Strafe.BL_StrafingController();
		}
	}
}