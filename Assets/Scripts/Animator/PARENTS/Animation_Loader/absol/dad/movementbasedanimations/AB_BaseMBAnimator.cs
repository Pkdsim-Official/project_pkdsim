using project_pkdsim.ANIMATOR.Parents.Absol.Dad.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Absol.Dad.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Absol.Dad.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Absol.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Absol.Dad.movementbasedanimations
{
	public class AbsolParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private ABParent_Jumping AB_MBA_Jumping;
		
		private ABParent_Running AB_MBA_Running;


		private ABParent_Turning AB_MBA_Turning;

		private ABParent_Strafing AB_MBA_Strafe;

		public void ABMovementAnimatorController()
		{
			AB_MBA_Running.ABParent_RunningController();

			AB_MBA_Jumping.ABParent_JumpingController();

			AB_MBA_Turning.ABParent_TurningController();	

			AB_MBA_Strafe.ABParent_StrafingController();
		}
	}
}