using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations
{
	public class GlaceonParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private GLParentMom_Jumping GL_MBA_Jumping;
		
		private GLParentMom_Running GL_MBA_Running;


		private GLParentMom_Turning GL_MBA_Turning;

		private GLParentMom_Strafing GL_MBA_Strafe;

		public void GLParentMom_MovementAnimatorController()
		{
			GL_MBA_Running.GLParentMom_RunningController();

			GL_MBA_Jumping.GLParentMom_JumpingController();

			GL_MBA_Turning.GLParentMom_TurningController();	

			GL_MBA_Strafe.GLParentMom_StrafingController();
		}
	}
}