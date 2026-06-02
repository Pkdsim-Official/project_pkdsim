using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.movementbasedanimations
{
	public class FlareonParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private FLParentMom_Jumping FLParentMom_MBA_Jumping;
		
		private FLParentMom_Running FLParentMom_MBA_Running;

		private FLParentMom_Turning FLParentMom_MBA_Turning;

		private FLParentMom_Strafing FLParentMom_MBA_Strafe;

		public void FLParentMom_MovementAnimatorController()
		{
			FLParentMom_MBA_Running.FLParentMom_RunningController();

			FLParentMom_MBA_Jumping.FLParentMom_JumpingController();

			FLParentMom_MBA_Turning.FLParentMom_TurningController();	

			FLParentMom_MBA_Strafe.FLParentMom_StrafingController();
		}
	}
}