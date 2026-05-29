using project_pkdsim.ANIMATOR.Parents.Gardevoir.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Gardevoir.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Gardevoir.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Gardevoir.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Gardevoir.movementbasedanimations
{
	public class GardevoirParent_AnimatorMovementController : MonoBehaviour 
	{
		private GARDParent_Jumping Gardevoir_MBA_Jumping;
		
		private GARDParent_Running Gardevoir_MBA_Running;


		private GARDParent_Turning Gardevoir_MBA_Turning;

		private GARDParent_Strafing Gardevoir_MBA_Strafe;

		public void GARDMovementAnimatorController()
		{
			Gardevoir_MBA_Running.GARDParent_RunningController();

			Gardevoir_MBA_Jumping.GARDParent_JumpingController();

			Gardevoir_MBA_Turning.GARDParent_TurningController();	

			Gardevoir_MBA_Strafe.GARDParent_StrafingController();
		}
	}
}