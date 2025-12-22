using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations
{
	public class SylveonParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private SYLParentMom_Jumping SYLParentMom_MBA_Jumping;
		
		private SYLParentMom_Running SYLParentMom_MBA_Running;


		private SYLParentMom_Turning SYLParentMom_MBA_Turning;

		private SYLParentMom_Strafing SYLParentMom_MBA_Strafe;

		public void SYLParentMom_MovementAnimatorController()
		{
			SYLParentMom_MBA_Running.SYLParentMom_RunningController();

			SYLParentMom_MBA_Jumping.SYLParentMom_JumpingController();

			SYLParentMom_MBA_Turning.SYLParentMom_TurningController();	

			SYLParentMom_MBA_Strafe.SYLParentMom_StrafingController();
		}
	}
}