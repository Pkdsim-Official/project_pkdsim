using project_pkdsim.ANIMATOR.Parents.Garchomp.Dad.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Garchomp.Dad.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Garchomp.Dad.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Garchomp.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Garchomp.Dad.movementbasedanimations
{
	public class GarchompParent_AnimatorMovementController : MonoBehaviour 
	{
		private GARCParent_Jumping Garchomp_MBA_Jumping;
		
		private GARCParent_Running Garchomp_MBA_Running;


		private GARCParent_Turning Garchomp_MBA_Turning;

		private GARCParent_Strafing Garchomp_MBA_Strafe;

		public void GARCMovementAnimatorController()
		{
			Garchomp_MBA_Running.GARCParent_RunningController();

			Garchomp_MBA_Jumping.GARCParent_JumpingController();

			Garchomp_MBA_Turning.GARCParent_TurningController();	

			Garchomp_MBA_Strafe.GARCParent_StrafingController();
		}
	}
}