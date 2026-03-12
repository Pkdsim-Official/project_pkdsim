using Project_Pkdsim.ANIMATOR.Npcs.Sylveon.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Npcs.Sylveon.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Npcs.Sylveon.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Npcs.Sylveon.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Npcs.Sylveon.movementbasedanimations
{
	public class Sylveon_MovementAnimatorController : MonoBehaviour 
	{
		private SYL_Jumping Sylveon_MBA_Jumping;
		
		private SYL_Running Sylveon_MBA_Running;

		private SYL_Turning Sylveon_MBA_Turning;

		private SYL_Strafing Sylveon_MBA_Strafe;

		public void SYL_MovementAnimatorController()
		{
			Sylveon_MBA_Running.SYL_RunningController();

			Sylveon_MBA_Jumping.SYL_JumpingController();

			Sylveon_MBA_Turning.SYL_TurningController();	

			Sylveon_MBA_Strafe.SYL_StrafingController();
		}	
	}
}