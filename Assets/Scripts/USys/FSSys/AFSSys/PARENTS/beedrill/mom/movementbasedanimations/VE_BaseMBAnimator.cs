using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.movementbasedanimations
{
	public class BeedrillParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private BEParentMom_Jumping BE_MBA_Jumping;
		
		private BEParentMom_Running BE_MBA_Running;


		private BEParentMom_Turning BE_MBA_Turning;

		private BEParentMom_Strafing BE_MBA_Strafe;

		public void BEParentMom_MovementAnimatorController()
		{
			BE_MBA_Running.BEParentMom_RunningController();

			BE_MBA_Jumping.BEParentMom_JumpingController();

			BE_MBA_Turning.BEParentMom_TurningController();	

			BE_MBA_Strafe.BEParentMom_StrafingController();
		}
	}
}