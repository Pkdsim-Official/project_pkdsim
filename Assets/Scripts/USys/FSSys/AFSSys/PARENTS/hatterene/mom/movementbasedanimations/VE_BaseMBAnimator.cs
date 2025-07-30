using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.movementbasedanimations
{
	public class HattereneParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private HATParentMom_Jumping HAT_MBA_Jumping;
		
		private HATParentMom_Running HAT_MBA_Running;


		private HATParentMom_Turning HAT_MBA_Turning;

		private HATParentMom_Strafing HAT_MBA_Strafe;

		public void HATParentMom_MovementAnimatorController()
		{
			HAT_MBA_Running.HATParentMom_RunningController();

			HAT_MBA_Jumping.HATParentMom_JumpingController();

			HAT_MBA_Turning.HATParentMom_TurningController();	

			HAT_MBA_Strafe.HATParentMom_StrafingController();
		}
	}
}