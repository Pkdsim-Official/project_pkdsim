using Project_Pkdsim.ANIMATOR.Npcs.Hatterene.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Npcs.Hatterene.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Npcs.Hatterene.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Npcs.Hatterene.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Hatterene.movementbasedanimations
{
	public class Hatterene_MovementAnimatorController : MonoBehaviour 
	{
		private HAT_Jumping Hatterene_MBA_Jumping;
		
		private HAT_Running Hatterene_MBA_Running;


		private HAT_Turning Hatterene_MBA_Turning;

		private HAT_Strafing Hatterene_MBA_Strafe;

		public void HATMovementAnimatorController()
		{
			Hatterene_MBA_Running.HAT_RunningController();

			Hatterene_MBA_Jumping.HAT_JumpingController();

			Hatterene_MBA_Turning.HAT_TurningController();	

			Hatterene_MBA_Strafe.HAT_StrafingController();
		}
	}
}