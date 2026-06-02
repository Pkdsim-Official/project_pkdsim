using project_pkdsim.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations
{
	public class LunalaParent_MovementAnimatorController : MonoBehaviour 
	{
		private LUNAParent_Jumping Lunala_MBA_Jumping;
		
		private LUNAParent_Running Lunala_MBA_Running;


		private LUNAParent_Turning Lunala_MBA_Turning;

		private LUNAParent_Strafing Lunala_MBA_Strafe;

		public void LUNAMovementAnimatorController()
		{
			Lunala_MBA_Running.LUNAParent_RunningController();

			Lunala_MBA_Jumping.LUNAParent_JumpingController();

			Lunala_MBA_Turning.LUNAParent_TurningController();	

			Lunala_MBA_Strafe.LUNAParent_StrafingController();
		}
	}
}