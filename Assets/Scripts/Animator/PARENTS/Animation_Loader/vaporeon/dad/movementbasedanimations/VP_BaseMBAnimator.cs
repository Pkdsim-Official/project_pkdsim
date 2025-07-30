using project_pkdsim.ANIMATOR.Parents.Vaporeon.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Vaporeon.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Vaporeon.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Vaporeon.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vaporeon.movementbasedanimations
{
	public class VaporeonParent_AnimatorBaseMovementController : MonoBehaviour 
	{
		private VPParent_Jumping VP_MBA_Jumping;
		
		private VPParent_Running VP_MBA_Running;

		private VPParent_Turning VP_MBA_Turning;

		private VPParent_Strafing VP_MBA_Strafe;

		private void VP_Base_IdleAnimatorController()
		{
			VP_MBA_Running.VPParent_RunningController();

			VP_MBA_Jumping.VPParent_JumpingController();

			VP_MBA_Turning.VPParent_TurningController();	

			VP_MBA_Strafe.VPParent_StrafingController();
		}
	}
}