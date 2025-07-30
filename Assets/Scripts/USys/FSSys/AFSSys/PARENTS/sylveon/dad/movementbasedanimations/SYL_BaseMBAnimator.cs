using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.movementbasedanimations.Jumping;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.movementbasedanimations.Running;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.movementbasedanimations.Strafing;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.movementbasedanimations
{
	public class SylveonParentDad_MovementAnimatorController : MonoBehaviour
	{
		private SYLParentDad_Jumping Sylveon_MBA_Jumping;

		private SYLParentDad_Running Sylveon_MBA_Running;

		private SYLParentDad_Turning Sylveon_MBA_Turning;

		private SYLParentDad_Strafing Sylveon_MBA_Strafe;

		public void SYLParentDad_MovementAnimatorController()
		{
			Sylveon_MBA_Running.SYLParentDad_RunningController();

			Sylveon_MBA_Jumping.SYLParentDad_JumpingController();

			Sylveon_MBA_Turning.SYLParentDad_TurningController();

			Sylveon_MBA_Strafe.SYLParentDad_StrafingController();
		}
	}
}