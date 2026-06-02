using project_pkdsim.ANIMATOR.Parents.Sylveon.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Sylveon.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Sylveon.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Sylveon.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Sylveon.movementbasedanimations
{
	public class SylveonParent_MovementAnimatorController : MonoBehaviour 
	{
		private SYLParent_Jumping Sylveon_MBA_Jumping;
		
		private SYLParent_Running Sylveon_MBA_Running;

		private SYLParent_Turning Sylveon_MBA_Turning;

		private SYLParent_Strafing Sylveon_MBA_Strafe;

		public void SYL_MovementAnimatorController()
		{
			Sylveon_MBA_Running.SYLParent_RunningController();

			Sylveon_MBA_Jumping.SYLParent_JumpingController();

			Sylveon_MBA_Turning.SYLParent_TurningController();	

			Sylveon_MBA_Strafe.SYLParent_StrafingController();
		}	
	}
}