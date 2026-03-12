using Project_Pkdsim.ANIMATOR.Npcs.Espeon.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Npcs.Espeon.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Npcs.Espeon.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Npcs.Espeon.movementbasedanimations.Turning;
using UnityEngine;


namespace Project_Pkdsim.ANIMATOR.Npcs.Espeon.movementbasedanimations
{
	public class Espeon_MovementAnimatorController : MonoBehaviour 
	{
		private ES_Jumping ES_MBA_Jumping;
		
		private ES_Running ES_MBA_Running;

		private ES_Turning ES_MBA_Turning;

		private ES_Strafing ES_MBA_Strafe;

		private void ES_Base_IdleAnimatorController()
		{
			ES_MBA_Running.ES_RunningController();

			ES_MBA_Jumping.ES_JumpingController();

			ES_MBA_Turning.ES_TurningController();	

			ES_MBA_Strafe.ES_StrafingController();
		}
	}
}