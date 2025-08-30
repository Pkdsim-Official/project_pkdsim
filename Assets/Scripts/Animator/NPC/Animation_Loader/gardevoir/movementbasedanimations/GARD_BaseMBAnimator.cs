using project_pkdsim.Models.ANIMATOR.NPC.Gardevoir.movementbasedanimations.Jumping;
using project_pkdsim.Models.ANIMATOR.NPC.Gardevoir.movementbasedanimations.Running;
using project_pkdsim.Models.ANIMATOR.NPC.Gardevoir.movementbasedanimations.Strafe;
using project_pkdsim.Models.ANIMATOR.NPC.Gardevoir.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Gardevoir.movementbasedanimations
{
	public class Gardevoir_AnimatorBaseMovementController : MonoBehaviour 
	{
		private GARD_Jumping Gardevoir_MBA_Jumping;
		
		private GARD_Running Gardevoir_MBA_Running;


		private GARD_Turning Gardevoir_MBA_Turning;

		private GARD_Strafing Gardevoir_MBA_Strafe;

		public void GARDMovementAnimatorController()
		{
			Gardevoir_MBA_Running.GARD_RunningController();

			Gardevoir_MBA_Jumping.GARD_JumpingController();

			Gardevoir_MBA_Turning.GARD_TurningController();	

			Gardevoir_MBA_Strafe.GARD_StrafingController();
		}
	}
}