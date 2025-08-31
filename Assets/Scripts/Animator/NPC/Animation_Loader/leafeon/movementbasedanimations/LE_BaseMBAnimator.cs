using project_pkdsim.Models.ANIMATOR.NPC.Leafeon.movementbasedanimations.Strafing;
using project_pkdsim.Models.ANIMATOR.NPC.Leafeon.movementbasedanimations.Jumping;
using project_pkdsim.Models.ANIMATOR.NPC.Leafeon.movementbasedanimations.Running;
using project_pkdsim.Models.ANIMATOR.NPC.Leafeon.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Leafeon.movementbasedanimations
{
	public class Leafeon_AnimatorBaseMovementController : MonoBehaviour 
	{
		private LE_Jumping LE_MBA_Jumping;
		
		private LE_Running LE_MBA_Running;

		private LE_Turning LE_MBA_Turning;

		private LE_Strafing LE_MBA_Strafe;

		private void LE_MovementAnimatorController()
		{
			LE_MBA_Running.LE_RunningController();

			LE_MBA_Jumping.LE_JumpingController();

			LE_MBA_Turning.LE_TurningController();	

			LE_MBA_Strafe.LE_StrafingController();
		}
	}
}