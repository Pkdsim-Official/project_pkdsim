using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.movementbasedanimations
{
	public class FrostlassParentDad_AnimatorMovementController : MonoBehaviour 
	{
		private FRParent_Jumping FrostlassParentDad_MBA_Jumping;
		
		private FRParent_Running FrostlassParentDad_MBA_Running;


		private FRParent_Turning FrostlassParentDad_MBA_Turning;

		private FRParent_Strafing FrostlassParentDad_MBA_Strafe;

		public void FRMovementAnimatorController()
		{
			FrostlassParentDad_MBA_Running.FRParent_RunningController();

			FrostlassParentDad_MBA_Jumping.FRParent_JumpingController();

			FrostlassParentDad_MBA_Turning.FRParent_TurningController();	

			FrostlassParentDad_MBA_Strafe.FRParent_StrafingController();
		}
	}
}