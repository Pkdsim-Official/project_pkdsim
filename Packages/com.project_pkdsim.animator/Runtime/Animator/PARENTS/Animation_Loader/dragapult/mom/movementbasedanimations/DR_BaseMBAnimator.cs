using project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations
{
	public class DelphoxParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private DRParent_Jumping DR_MBA_Jumping;
		
		private DRParent_Running DR_MBA_Running;


		private DRParent_Turning DR_MBA_Turning;

		private DRParent_Strafing DR_MBA_Strafe;

		public void DRMovementAnimatorController()
		{
			DR_MBA_Running.DRParent_RunningController();

			DR_MBA_Jumping.DRParent_JumpingController();

			DR_MBA_Turning.DRParent_TurningController();	

			DR_MBA_Strafe.DRParent_StrafingController();
		}
	}
}