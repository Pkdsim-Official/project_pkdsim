using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.movementbasedanimations.Jumping;
using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.movementbasedanimations.Running;
using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.movementbasedanimations.Strafe;
using project_pkdsim.Models.ANIMATOR.NPC.Beedrill.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Beedrill.movementbasedanimations
{
	public class Beedrill_AnimatorBaseMovementController : MonoBehaviour 
	{
		private BE_Jumping Beedrill_MBA_Jumping;
		
		private BE_Running Beedrill_MBA_Running;


		private BE_Turning Beedrill_MBA_Turning;

		private BE_Strafing Beedrill_MBA_Strafe;

		public void BEMovementAnimatorController()
		{
			Beedrill_MBA_Running.BE_RunningController();

			Beedrill_MBA_Jumping.BE_JumpingController();

			Beedrill_MBA_Turning.BE_TurningController();	

			Beedrill_MBA_Strafe.BE_StrafingController();
		}
	}
}