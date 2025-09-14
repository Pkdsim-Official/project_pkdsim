using project_pkdsim.ANIMATOR.Npcs.Salazzle.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Npcs.Salazzle.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Npcs.Salazzle.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Npcs.Salazzle.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Npcs.Salazzle.movementbasedanimations
{
	public class Salazzle_MovementAnimatorController : MonoBehaviour 
	{
		private SA_Jumping SA_MBA_Jumping;
		
		private SA_Running SA_MBA_Running;


		private SA_Turning SA_MBA_Turning;

		private SA_Strafing SA_MBA_Strafe;

		public void SA_MovementAnimatorController()
		{
			SA_MBA_Running.SA_RunningController();

			SA_MBA_Jumping.SA_JumpingController();

			SA_MBA_Turning.SA_TurningController();	

			SA_MBA_Strafe.SA_StrafingController();
		}
	}
}