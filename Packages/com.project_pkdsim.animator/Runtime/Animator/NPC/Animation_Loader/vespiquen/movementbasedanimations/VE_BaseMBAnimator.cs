using project_pkdsim.ANIMATOR.NPC.Vespiquen.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.NPC.Vespiquen.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.NPC.Vespiquen.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.NPC.Vespiquen.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Vespiquen.movementbasedanimations
{
	public class Vespiquen_AnimatorBaseMovementController : MonoBehaviour 
	{
		private VE_Jumping VE_MBA_Jumping;
		
		private VE_Running VE_MBA_Running;


		private VE_Turning VE_MBA_Turning;

		private VE_Strafing VE_MBA_Strafe;

		public void VEMovementAnimatorController()
		{
			VE_MBA_Running.VE_RunningController();

			VE_MBA_Jumping.VE_JumpingController();

			VE_MBA_Turning.VE_TurningController();	

			VE_MBA_Strafe.VE_StrafingController();
		}
	}
}