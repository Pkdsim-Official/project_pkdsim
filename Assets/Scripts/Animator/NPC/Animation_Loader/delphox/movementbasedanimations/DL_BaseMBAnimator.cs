using project_pkdsim.ANIMATOR.NPC.Delphox.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.NPC.Delphox.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.NPC.Delphox.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.NPC.Delphox.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Delphox.movementbasedanimations
{
	public class Delphox_AnimatorBaseMovementController : MonoBehaviour 
	{
		private DL_Jumping DL_MBA_Jumping;
		
		private DL_Running DL_MBA_Running;


		private DL_Turning DL_MBA_Turning;

		private DL_Strafing DL_MBA_Strafe;

		public void DLMovementAnimatorController()
		{
			DL_MBA_Running.DL_RunningController();

			DL_MBA_Jumping.DL_JumpingController();

			DL_MBA_Turning.DL_TurningController();	

			DL_MBA_Strafe.DL_StrafingController();
		}
	}
}