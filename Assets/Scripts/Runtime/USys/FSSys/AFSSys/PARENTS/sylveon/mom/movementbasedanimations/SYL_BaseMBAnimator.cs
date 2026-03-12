using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations.Jumping;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations.Running;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations.Strafing;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations
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