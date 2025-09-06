using project_pkdsim.ANIMATOR.NPC.Salazzle.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.NPC.Salazzle.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.NPC.Salazzle.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.NPC.Salazzle.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.NPC.Salazzle.movementbasedanimations
{
	public class Salazzle_AnimatorBaseMovementController : MonoBehaviour 
	{
		private SA_Jumping SA_MBA_Jumping;
		
		private SA_Running SA_MBA_Running;


		private SA_Turning SA_MBA_Turning;

		private SA_Strafing SA_MBA_Strafe;

		public void SA_MovementAnimatorController()
		{
			SA_MBA_Running.SA_RunningController();

			SA_MBA_Jumping.SA_JumpingController();

			SA_MBA_Turning.SA_TurningController();	

			SA_MBA_Strafe.SA_StrafingController();
		}
	}
}