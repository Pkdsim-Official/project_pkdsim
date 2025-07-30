using project_pkdsim.Models.ANIMATOR.NPC.Sylveon.movementbasedanimations.Jumping;
using project_pkdsim.Models.ANIMATOR.NPC.Sylveon.movementbasedanimations.Running;
using project_pkdsim.Models.ANIMATOR.NPC.Sylveon.movementbasedanimations.Strafe;
using project_pkdsim.Models.ANIMATOR.NPC.Sylveon.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Sylveon.movementbasedanimations
{
	public class Sylveon_AnimatorBaseMovementController : MonoBehaviour 
	{
		private SYL_Jumping Sylveon_MBA_Jumping;
		
		private SYL_Running Sylveon_MBA_Running;

		private SYL_Turning Sylveon_MBA_Turning;

		private SYL_Strafing Sylveon_MBA_Strafe;

		public void SYL_MovementAnimatorController()
		{
			Sylveon_MBA_Running.SYL_RunningController();

			Sylveon_MBA_Jumping.SYL_JumpingController();

			Sylveon_MBA_Turning.SYL_TurningController();	

			Sylveon_MBA_Strafe.SYL_StrafingController();
		}	
	}
}