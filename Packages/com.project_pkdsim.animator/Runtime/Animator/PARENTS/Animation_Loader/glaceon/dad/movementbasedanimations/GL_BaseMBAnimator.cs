using project_pkdsim.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations
{
	public class GlaceonParent_MovementAnimatorController : MonoBehaviour 
	{
		private GLParent_Jumping GL_MBA_Jumping;
		
		private GLParent_Running GL_MBA_Running;

		private GLParent_Turning GL_MBA_Turning;

		private GL_Strafe GL_MBA_Strafe;

		private void GLParent_IdleAnimatorController()
		{
			GL_MBA_Running.GLParent_RunningController();

			GL_MBA_Jumping.GLParent_JumpingController();

			GL_MBA_Turning.GLParent_TurningController();	

			GL_MBA_Strafe.GLParent_StrafingController();
		}
	}
}