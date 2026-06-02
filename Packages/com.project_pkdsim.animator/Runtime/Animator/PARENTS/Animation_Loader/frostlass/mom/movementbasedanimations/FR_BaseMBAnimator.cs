using project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.Mom.movementbasedanimations
{
	public class FrostlassParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private FRParent_Jumping FrostlassParentMom_MBA_Jumping;
		
		private FRParent_Running FrostlassParentMom_MBA_Running;


		private FRParent_Turning FrostlassParentMom_MBA_Turning;

		private FRParent_Strafing FrostlassParentMom_MBA_Strafe;

		public void FRMovementAnimatorController()
		{
			FrostlassParentMom_MBA_Running.FRParent_RunningController();

			FrostlassParentMom_MBA_Jumping.FRParent_JumpingController();

			FrostlassParentMom_MBA_Turning.FRParent_TurningController();	

			FrostlassParentMom_MBA_Strafe.FRParent_StrafingController();
		}
	}
}