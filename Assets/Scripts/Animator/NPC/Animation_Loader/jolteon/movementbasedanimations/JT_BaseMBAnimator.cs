using project_pkdsim.ANIMATOR.Npcs.Jolteon.movementbasedanimations.Turning;
using project_pkdsim.ANIMATOR.Npcs.Jolteon.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Npcs.Jolteon.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Npcs.Jolteon.movementbasedanimations.Running;
using UnityEngine;


namespace project_pkdsim.ANIMATOR.Npcs.Jolteon.movementbasedanimations
{
	public class Jolteon_MovementAnimatorController : MonoBehaviour 
	{
		private JT_Jumping JT_MBA_Jumping;
		
		private JT_Running JT_MBA_Running;

		private JT_Turning JT_MBA_Turning;

		private JT_Strafing JT_MBA_Strafe;

		public void JT_MovementAnimatorController()
		{
			JT_MBA_Running.JT_RunningController();

			JT_MBA_Jumping.JT_JumpingController();

			JT_MBA_Turning.JT_TurningController();	

			JT_MBA_Strafe.JT_StrafingController();
		}
	}
}