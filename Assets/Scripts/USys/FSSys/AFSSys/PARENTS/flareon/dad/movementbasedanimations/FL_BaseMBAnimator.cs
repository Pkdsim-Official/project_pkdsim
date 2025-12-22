using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.movementbasedanimations.Jumping;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.movementbasedanimations.Running;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.movementbasedanimations.Strafing;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.movementbasedanimations
{
	public class FlareonParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private FLParentDad_Jumping FL_MBA_Jumping;
		
		private FLParentDad_Running FL_MBA_Running;

		private FLParentDad_Turning FL_MBA_Turning;

		private FLParentDad_Strafing FL_MBA_Strafe;

		public void FLParentDad_MovementAnimatorController()
		{
			FL_MBA_Running.FLParentDad_RunningController();

			FL_MBA_Jumping.FLParentDad_JumpingController();

			FL_MBA_Turning.FLParentDad_TurningController();	

			FL_MBA_Strafe.FLParentDad_StrafingController();
		}
	}
}