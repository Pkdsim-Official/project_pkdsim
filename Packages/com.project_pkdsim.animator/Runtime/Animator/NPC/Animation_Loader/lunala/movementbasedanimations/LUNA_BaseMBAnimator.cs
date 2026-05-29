using project_pkdsim.ANIMATOR.NPC.Lunala.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.NPC.Lunala.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.NPC.Lunala.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.NPC.Lunala.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Lunala.movementbasedanimations
{
	public class Lunala_AnimatorMovementController : MonoBehaviour 
	{
		private LUNA_Jumping Lunala_MBA_Jumping;
		
		private LUNA_Running Lunala_MBA_Running;


		private LUNA_Turning Lunala_MBA_Turning;

		private LUNA_Strafing Lunala_MBA_Strafe;

		public void LUNAMovementAnimatorController()
		{
			Lunala_MBA_Running.LUNA_RunningController();

			Lunala_MBA_Jumping.LUNA_JumpingController();

			Lunala_MBA_Turning.LUNA_TurningController();	

			Lunala_MBA_Strafe.LUNA_StrafingController();
		}
	}
}