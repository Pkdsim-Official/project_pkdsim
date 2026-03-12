using Project_Pkdsim.ANIMATOR.Npcs.Leafeon.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Npcs.Leafeon.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Npcs.Leafeon.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Npcs.Leafeon.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Leafeon.movementbasedanimations
{
	public class Leafeon_MovementAnimatorController : MonoBehaviour 
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