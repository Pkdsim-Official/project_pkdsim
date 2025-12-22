using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Mom.movementbasedanimations
{
	public class FrostlassParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private FRParentMom_Jumping FR_MBA_Jumping;
		
		private FRParentMom_Running FR_MBA_Running;


		private FRParentMom_Turning FR_MBA_Turning;

		private FRParentMom_Strafing FR_MBA_Strafe;

		public void FRParentMom_MovementAnimatorController()
		{
			FR_MBA_Running.FRParentMom_RunningController();

			FR_MBA_Jumping.FRParentMom_JumpingController();

			FR_MBA_Turning.FRParentMom_TurningController();	

			FR_MBA_Strafe.FRParentMom_StrafingController();
		}
	}
}