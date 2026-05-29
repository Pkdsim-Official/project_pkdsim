using project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations
{
	public class GlaceonParent_AnimatorMovementController : MonoBehaviour 
	{
		private GLParent_Jumping GL_MBA_Jumping;
		
		private GLParent_Running GL_MBA_Running;

		private GLParent_Turning GL_MBA_Turning;

		private GL_Strafe GL_MBA_Strafe;

		private void GL_Base_IdleAnimatorController()
		{
			GL_MBA_Running.GLParent_RunningController();

			GL_MBA_Jumping.GLParent_JumpingController();

			GL_MBA_Turning.GLParent_TurningController();	

			GL_MBA_Strafe.GLParent_StrafingController();
		}
	}
}