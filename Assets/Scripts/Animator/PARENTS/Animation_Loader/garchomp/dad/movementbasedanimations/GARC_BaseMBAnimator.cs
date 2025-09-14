using project_pkdsim.ANIMATOR.Parents.Garchomp.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Garchomp.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Garchomp.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Garchomp.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Garchomp.movementbasedanimations
{
	public class GarchompParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private GARCParentDad_Jumping Garchomp_MBA_Jumping;
		
		private GARCParentDad_Running Garchomp_MBA_Running;


		private GARCParentDad_Turning Garchomp_MBA_Turning;

		private GARCParentDad_Strafing Garchomp_MBA_Strafe;

		public void GARCMovementAnimatorController()
		{
			Garchomp_MBA_Running.GARCParentDad_RunningController();

			Garchomp_MBA_Jumping.GARCParentDad_JumpingController();

			Garchomp_MBA_Turning.GARCParentDad_TurningController();	

			Garchomp_MBA_Strafe.GARCParentDad_StrafingController();
		}
	}
}