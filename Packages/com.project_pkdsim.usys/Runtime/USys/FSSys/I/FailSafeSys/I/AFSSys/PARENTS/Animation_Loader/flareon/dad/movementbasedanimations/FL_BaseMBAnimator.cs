using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Dad.movementbasedanimations
{
	public class FlareonParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private FLParentDad_Jumping FLParentDad_MBA_Jumping;
		
		private FLParentDad_Running FLParentDad_MBA_Running;

		private FLParentDad_Turning FLParentDad_MBA_Turning;

		private FLParentDad_Strafing FLParentDad_MBA_Strafe;

		public void FLParentDad_MovementAnimatorController()
		{
			FLParentDad_MBA_Running.FLParentDad_RunningController();

			FLParentDad_MBA_Jumping.FLParentDad_JumpingController();

			FLParentDad_MBA_Turning.FLParentDad_TurningController();	

			FLParentDad_MBA_Strafe.FLParentDad_StrafingController();
		}
	}
}