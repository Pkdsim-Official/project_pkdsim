using project_pkdsim.ANIMATOR.NPC.Cinderace.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.NPC.Cinderace.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.NPC.Cinderace.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.NPC.Cinderace.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Cinderace.movementbasedanimations
{
	public class Cinderace_AnimatorMovementController : MonoBehaviour 
	{
		private C_Jumping C_MBA_Jumping;
		
		private C_Running C_MBA_Running;


		private C_Turning C_MBA_Turning;

		private C_Strafing C_MBA_Strafe;

		public void CMovementAnimatorController()
		{
			C_MBA_Running.C_RunningController();

			C_MBA_Jumping.C_JumpingController();

			C_MBA_Turning.C_TurningController();	

			C_MBA_Strafe.C_StrafingController();
		}
	}
}