using project_pkdsim.ANIMATOR.Parents.Cinderace.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Cinderace.Mom.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Cinderace.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Cinderace.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Cinderace.Mom.movementbasedanimations
{
	public class CinderaceParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private CParent_Jumping C_MBA_Jumping;
		
		private CParent_Running C_MBA_Running;


		private CParent_Turning C_MBA_Turning;

		private CParent_Strafing C_MBA_Strafe;

		public void CMovementAnimatorController()
		{
			C_MBA_Running.CParent_RunningController();

			C_MBA_Jumping.CParent_JumpingController();

			C_MBA_Turning.CParent_TurningController();	

			C_MBA_Strafe.CParent_StrafingController();
		}
	}
}