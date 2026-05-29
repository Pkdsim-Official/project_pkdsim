using project_pkdsim.ANIMATOR.NPC.Dragapult.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.NPC.Dragapult.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.NPC.Dragapult.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.NPC.Dragapult.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Dragapult.movementbasedanimations
{
	public class Dragapult_AnimatorMovementController : MonoBehaviour 
	{
		private DR_Jumping DR_MBA_Jumping;
		
		private DR_Running DR_MBA_Running;


		private DR_Turning DR_MBA_Turning;

		private DR_Strafing DR_MBA_Strafe;

		public void DRMovementAnimatorController()
		{
			DR_MBA_Running.DR_RunningController();

			DR_MBA_Jumping.DR_JumpingController();

			DR_MBA_Turning.DR_TurningController();	

			DR_MBA_Strafe.DR_StrafingController();
		}
	}
}