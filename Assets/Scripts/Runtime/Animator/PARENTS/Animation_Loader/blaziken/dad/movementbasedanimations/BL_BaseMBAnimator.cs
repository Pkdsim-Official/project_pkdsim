using Project_Pkdsim.ANIMATOR.Parents.Blaziken.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Parents.Blaziken.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Parents.Blaziken.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Parents.Blaziken.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Blaziken.movementbasedanimations
{
	public class BlazikenParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private BLParent_Jumping BL_MBA_Jumping;
		
		private BLParent_Running BL_MBA_Running;


		private BLParent_Turning BL_MBA_Turning;

		private BLParent_Strafing BL_MBA_Strafe;

		public void BLMovementAnimatorController()
		{
			BL_MBA_Running.BLParent_RunningController();

			BL_MBA_Jumping.BLParent_JumpingController();

			BL_MBA_Turning.BLParent_TurningController();	

			BL_MBA_Strafe.BLParent_StrafingController();
		}
	}
}