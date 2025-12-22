using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.movementbasedanimations.Turning;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.movementbasedanimations.Strafing;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.movementbasedanimations.Jumping;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.movementbasedanimations.Running;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.movementbasedanimations
{
	public class JolteonParentDad_MovementAnimatorController : MonoBehaviour
	{
		private JTParentDad_Jumping JT_MBA_Jumping;

		private JTParentDad_Running JT_MBA_Running;

		private JTParentDad_Turning JT_MBA_Turning;

		private JTParentDad_Strafing JT_MBA_Strafe;

		public void JTParentDad_MovementAnimatorController()
		{
			JT_MBA_Running.JTParentDad_RunningController();

			JT_MBA_Jumping.JTParentDad_JumpingController();

			JT_MBA_Turning.JTParentDad_TurningController();

			JT_MBA_Strafe.JTParentDad_StrafingController();
		}
	}
}