using project_pkdsim.ANIMATOR.NPC.Zoroark.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.NPC.Zoroark.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.NPC.Zoroark.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.NPC.Zoroark.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Zoroark.movementbasedanimations
{
	public class Zoroark_AnimatorBaseMovementController : MonoBehaviour 
	{
		private Z_Jumping Zoroark_MBA_Jumping;
		
		private Z_Running Zoroark_MBA_Running;


		private Z_Turning Zoroark_MBA_Turning;

		private Z_Strafing Zoroark_MBA_Strafe;

		public void ZMovementAnimatorController()
		{
			Zoroark_MBA_Running.Z_RunningController();

			Zoroark_MBA_Jumping.Z_JumpingController();

			Zoroark_MBA_Turning.Z_TurningController();	

			Zoroark_MBA_Strafe.Z_StrafingController();
		}
	}
}