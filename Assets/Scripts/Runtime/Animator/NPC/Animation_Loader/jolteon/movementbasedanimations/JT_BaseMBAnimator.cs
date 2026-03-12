using Project_Pkdsim.ANIMATOR.Npcs.Jolteon.movementbasedanimations.Turning;
using Project_Pkdsim.ANIMATOR.Npcs.Jolteon.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Npcs.Jolteon.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Npcs.Jolteon.movementbasedanimations.Running;
using UnityEngine;


namespace Project_Pkdsim.ANIMATOR.Npcs.Jolteon.movementbasedanimations
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