using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.movementbasedanimations.Jumping;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.movementbasedanimations.Running;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.movementbasedanimations.Strafing;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.movementbasedanimations
{
	public class FrostlassParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private FRParent_Jumping Frostlass_MBA_Jumping;
		
		private FRParent_Running Frostlass_MBA_Running;


		private FRParent_Turning Frostlass_MBA_Turning;

		private FRParent_Strafing Frostlass_MBA_Strafe;

		public void FRMovementAnimatorController()
		{
			Frostlass_MBA_Running.FRParent_RunningController();

			Frostlass_MBA_Jumping.FRParent_JumpingController();

			Frostlass_MBA_Turning.FRParent_TurningController();	

			Frostlass_MBA_Strafe.FRParent_StrafingController();
		}
	}
}