using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Jumping;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Running;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Strafing;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations
{
	public class GlaceonParentDad_MovementAnimatorController : MonoBehaviour
	{
		private GLParentDad_Jumping GL_MBA_Jumping;

		private GLParentDad_Running GL_MBA_Running;

		private GLParentDad_Turning GL_MBA_Turning;

		private GLParentDad_Strafe GL_MBA_Strafe;

		public void GLParentDad_MovementAnimatorController()
		{
			GL_MBA_Running.GLParentDad_RunningController();

			GL_MBA_Jumping.GLParentDad_JumpingController();

			GL_MBA_Turning.GLParentDad_TurningController();

			GL_MBA_Strafe.GLParentDad_StrafingController();
		}
	}
}