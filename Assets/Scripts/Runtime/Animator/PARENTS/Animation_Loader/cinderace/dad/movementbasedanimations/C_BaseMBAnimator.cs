using Project_Pkdsim.ANIMATOR.Parents.Cinderace.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Parents.Cinderace.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Parents.Cinderace.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Parents.Cinderace.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Cinderace.Dad.movementbasedanimations
{
	public class CinderaceParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private ParentDad_Jumping C_MBA_Jumping;
		
		private ParentDad_Running C_MBA_Running;


		private ParentDad_Turning C_MBA_Turning;

		private ParentDad_Strafing C_MBA_Strafe;

		public void CMovementAnimatorController()
		{
			C_MBA_Running.ParentDad_RunningController();

			C_MBA_Jumping.ParentDad_JumpingController();

			C_MBA_Turning.ParentDad_TurningController();	

			C_MBA_Strafe.ParentDad_StrafingController();
		}
	}
}