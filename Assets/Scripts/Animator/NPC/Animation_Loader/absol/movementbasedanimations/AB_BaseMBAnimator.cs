using project_pkdsim.Models.ANIMATOR.NPC.Absol.movementbasedanimations.Jumping;
using project_pkdsim.Models.ANIMATOR.NPC.Absol.movementbasedanimations.Running;
using project_pkdsim.Models.ANIMATOR.NPC.Absol.movementbasedanimations.Strafing;
using project_pkdsim.Models.ANIMATOR.NPC.Absol.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Absol.movementbasedanimations
{
	public class Absol_AnimatorBaseMovementController : MonoBehaviour 
	{
		private AB_Jumping AB_MBA_Jumping;
		
		private AB_Running AB_MBA_Running;


		private AB_Turning AB_MBA_Turning;

		private AB_Strafing AB_MBA_Strafe;

		public void ABMovementAnimatorController()
		{
			AB_MBA_Running.AB_RunningController();

			AB_MBA_Jumping.AB_JumpingController();

			AB_MBA_Turning.AB_TurningController();	

			AB_MBA_Strafe.AB_StrafingController();
		}
	}
}