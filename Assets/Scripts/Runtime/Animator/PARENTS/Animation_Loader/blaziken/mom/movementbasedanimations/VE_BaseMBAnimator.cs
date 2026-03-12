using Project_Pkdsim.ANIMATOR.Parents.Blaziken.Mom.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Parents.Blaziken.Mom.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Parents.Blaziken.Mom.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Parents.Blaziken.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Blaziken.Mom.movementbasedanimations
{
	public class BlazikenParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private BLParentMom_Jumping BL_MBA_Jumping;
		
		private BLParentMom_Running BL_MBA_Running;


		private BLParentMom_Turning BL_MBA_Turning;

		private BLParentMom_Strafing BL_MBA_Strafe;

		public void BLParentMom_MovementAnimatorController()
		{
			BL_MBA_Running.BLParentMom_RunningController();

			BL_MBA_Jumping.BLParentMom_JumpingController();

			BL_MBA_Turning.BLParentMom_TurningController();	

			BL_MBA_Strafe.BLParentMom_StrafingController();
		}
	}
}