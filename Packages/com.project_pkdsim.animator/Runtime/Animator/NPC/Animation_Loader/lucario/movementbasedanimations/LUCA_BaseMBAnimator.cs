using project_pkdsim.ANIMATOR.NPC.Lucario.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.NPC.Lucario.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.NPC.Lucario.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.NPC.Lucario.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Lucario.movementbasedanimations
{
	public class Lucario_AnimatorMovementController : MonoBehaviour 
	{
		private LUCA_Jumping Lucario_MBA_Jumping;
		
		private LUCA_Running Lucario_MBA_Running;


		private LUCA_Turning Lucario_MBA_Turning;

		private LUCA_Strafing Lucario_MBA_Strafe;

		public void LUCAMovementAnimatorController()
		{
			Lucario_MBA_Running.LUCA_RunningController();

			Lucario_MBA_Jumping.LUCA_JumpingController();

			Lucario_MBA_Turning.LUCA_TurningController();	

			Lucario_MBA_Strafe.LUCA_StrafingController();
		}
	}
}