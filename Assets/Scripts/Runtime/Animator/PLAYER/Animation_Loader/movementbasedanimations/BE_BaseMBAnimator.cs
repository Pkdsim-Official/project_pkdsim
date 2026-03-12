using Project_Pkdsim.ANIMATOR.Player.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Player.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Player.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Player.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Player.movementbasedanimations
{
	public class Player_MovementAnimatorController : MonoBehaviour 
	{
		private Player_Jumping Player_MBA_Jumping;
		
		private Player_Running Player_MBA_Running;

		private Player_Turning Player_MBA_Turning;

		private Player_Strafing Player_MBA_Strafing;

		public void PL_MovementAnimatorController()
		{
			Player_MBA_Running.Player_RunningController();

			Player_MBA_Jumping.Player_JumpingController();

			Player_MBA_Turning.Player_TurningController();	

			Player_MBA_Strafing.Player_StrafingController();
		}
	}
}