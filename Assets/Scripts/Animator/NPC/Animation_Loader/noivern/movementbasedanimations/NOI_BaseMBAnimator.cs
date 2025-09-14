using project_pkdsim.ANIMATOR.Npcs.Noivern.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Npcs.Noivern.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Npcs.Noivern.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Npcs.Noivern.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Noivern.movementbasedanimations
{
	public class Noivern_MovementAnimatorController : MonoBehaviour 
	{
		private NOI_Jumping Noivern_MBA_Jumping;
		
		private NOI_Running Noivern_MBA_Running;


		private NOI_Turning Noivern_MBA_Turning;

		private NOI_Strafing Noivern_MBA_Strafe;

		public void NOIMovementAnimatorController()
		{
			Noivern_MBA_Running.NOI_RunningController();

			Noivern_MBA_Jumping.NOI_JumpingController();

			Noivern_MBA_Turning.NOI_TurningController();	

			Noivern_MBA_Strafe.NOI_StrafingController();
		}
	}
}