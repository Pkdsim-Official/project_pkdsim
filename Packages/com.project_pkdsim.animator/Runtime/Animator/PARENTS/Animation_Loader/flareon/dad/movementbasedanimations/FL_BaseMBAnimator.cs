using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Frostlass.Dad.movementbasedanimations
{
	public class FlareonParent_AnimatorMovementController : MonoBehaviour 
	{
		private FLParent_Jumping FL_MBA_Jumping;
		
		private FLParent_Running FL_MBA_Running;

		private FLParent_Turning FL_MBA_Turning;

		private FLParent_Strafing FL_MBA_Strafe;

		private void FL_Base_IdleAnimatorController()
		{
			FL_MBA_Running.FLParent_RunningController();

			FL_MBA_Jumping.FLParent_JumpingController();

			FL_MBA_Turning.FLParent_TurningController();	

			FL_MBA_Strafe.FLParent_StrafingController();
		}
	}
}