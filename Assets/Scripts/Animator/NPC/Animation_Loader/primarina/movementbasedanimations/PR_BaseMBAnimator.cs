using project_pkdsim.Models.ANIMATOR.NPC.Primarina.movementbasedanimations.Jumping;
using project_pkdsim.Models.ANIMATOR.NPC.Primarina.movementbasedanimations.Running;
using project_pkdsim.Models.ANIMATOR.NPC.Primarina.movementbasedanimations.Strafing;
using project_pkdsim.Models.ANIMATOR.NPC.Primarina.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Primarina.movementbasedanimations
{
	public class Primarina_AnimatorBaseMovementController : MonoBehaviour 
	{
		private PR_Jumping Primarina_MBA_Jumping;
		
		private PR_Running Primarina_MBA_Running;


		private PR_Turning Primarina_MBA_Turning;

		private PR_Strafing Primarina_MBA_Strafe;

		public void PRMovementAnimatorController()
		{
			Primarina_MBA_Running.PR_RunningController();

			Primarina_MBA_Jumping.PR_JumpingController();

			Primarina_MBA_Turning.PR_TurningController();	

			Primarina_MBA_Strafe.PR_StrafingController();
		}
	}
}