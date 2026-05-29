using project_pkdsim.ANIMATOR.NPC.Garchomp.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.NPC.Garchomp.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.NPC.Garchomp.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.NPC.Garchomp.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Garchomp.movementbasedanimations
{
	public class Garchomp_AnimatorMovementController : MonoBehaviour 
	{
		private GARC_Jumping Garchomp_MBA_Jumping;
		
		private GARC_Running Garchomp_MBA_Running;


		private GARC_Turning Garchomp_MBA_Turning;

		private GARC_Strafing Garchomp_MBA_Strafe;

		public void GARCMovementAnimatorController()
		{
			Garchomp_MBA_Running.GARC_RunningController();

			Garchomp_MBA_Jumping.GARC_JumpingController();

			Garchomp_MBA_Turning.GARC_TurningController();	

			Garchomp_MBA_Strafe.GARC_StrafingController();
		}
	}
}