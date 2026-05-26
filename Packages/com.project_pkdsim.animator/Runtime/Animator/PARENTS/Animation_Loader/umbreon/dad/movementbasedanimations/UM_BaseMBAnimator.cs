using project_pkdsim.ANIMATOR.Parents.Umbreon.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Umbreon.movementbasedanimations.Turning;
using project_pkdsim.ANIMATOR.Parents.Umbreon.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Umbreon.movementbasedanimations.Strafing;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Umbreon.movementbasedanimations
{
	public class UmbreonParent_AnimatorBaseMovementController : MonoBehaviour 
	{
		private UMParent_Jumping UM_MBA_Jumping;
		
		private UMParent_Running UM_MBA_Running;

		private UMParent_Turning UM_MBA_Turning;

		private UMParent_Strafing UM_MBA_Strafe;

		private void UM_MovementAnimatorController()
		{
			UM_MBA_Running.UMParent_RunningController();

			UM_MBA_Jumping.UMParent_JumpingController();

			UM_MBA_Turning.UMParent_TurningController();	

			UM_MBA_Strafe.UMParent_StrafingController();
		}	
	}
}