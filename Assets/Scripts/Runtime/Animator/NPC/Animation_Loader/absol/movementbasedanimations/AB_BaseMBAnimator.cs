using Project_Pkdsim.ANIMATOR.Npcs.Absol.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Npcs.Absol.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Npcs.Absol.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Npcs.Absol.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Absol.movementbasedanimations
{
	public class Absol_MovementAnimatorController : MonoBehaviour 
	{
		private AB_Jumping AB_MBA_Jumping;
		
		private AB_Running AB_MBA_Running;


		private AB_Turning AB_MBA_Turning;

		private AB_Strafing AB_MBA_Strafe;

		public void AB_MovementAnimatorController()
		{
			AB_MBA_Running.AB_RunningController();

			AB_MBA_Jumping.AB_JumpingController();

			AB_MBA_Turning.AB_TurningController();	

			AB_MBA_Strafe.AB_StrafingController();
		}
	}
}