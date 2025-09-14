using project_pkdsim.ANIMATOR.Npcs.Umbreon.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Npcs.Umbreon.movementbasedanimations.Turning;
using project_pkdsim.ANIMATOR.Npcs.Umbreon.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Npcs.Umbreon.movementbasedanimations.Strafing;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Umbreon.movementbasedanimations
{
	public class Umbreon_MovementAnimatorController : MonoBehaviour 
	{
		private UM_Jumping UM_MBA_Jumping;
		
		private UM_Running UM_MBA_Running;

		private UM_Turning UM_MBA_Turning;

		private UM_Strafing UM_MBA_Strafe;

		private void UM_MovementAnimatorController()
		{
			UM_MBA_Running.UM_RunningController();

			UM_MBA_Jumping.UM_JumpingController();

			UM_MBA_Turning.UM_TurningController();	

			UM_MBA_Strafe.UM_StrafingController();
		}	
	}
}