using Project_Pkdsim.ANIMATOR.Npcs.Lopunny.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Npcs.Lopunny.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Npcs.Lopunny.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Npcs.Lopunny.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Lopunny.movementbasedanimations
{
	public class Lopunny_MovementAnimatorController : MonoBehaviour 
	{
		private LO_Jumping Lopunny_MBA_Jumping;
		
		private LO_Running Lopunny_MBA_Running;


		private LO_Turning Lopunny_MBA_Turning;

		private LO_Strafing Lopunny_MBA_Strafe;

		public void LO_MovementAnimatorController()
		{
			Lopunny_MBA_Running.LO_RunningController();

			Lopunny_MBA_Jumping.LO_JumpingController();

			Lopunny_MBA_Turning.LO_TurningController();	

			Lopunny_MBA_Strafe.LO_StrafingController();
		}
	}
}