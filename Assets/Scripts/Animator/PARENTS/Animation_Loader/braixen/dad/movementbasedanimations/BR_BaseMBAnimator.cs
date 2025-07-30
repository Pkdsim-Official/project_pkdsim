using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Braixen.Dad.movementbasedanimations
{
	public class BraixenParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private BRParentDad_Jumping BRParentDad_MBA_Jumping;
		
		private BRParentDad_Running BRParentDad_MBA_Running;


		private BRParentDad_Turning BRParentDad_MBA_Turning;

		private BRParentDad_Strafing BRParentDad_MBA_Strafe;

		public void BRMovementAnimatorController()
		{
			BRParentDad_MBA_Running.BRParentDad_RunningController();

			BRParentDad_MBA_Jumping.BRParentDad_JumpingController();

			BRParentDad_MBA_Turning.BRParentDad_TurningController();	

			BRParentDad_MBA_Strafe.BRParentDad_StrafingController();
		}
	}
}