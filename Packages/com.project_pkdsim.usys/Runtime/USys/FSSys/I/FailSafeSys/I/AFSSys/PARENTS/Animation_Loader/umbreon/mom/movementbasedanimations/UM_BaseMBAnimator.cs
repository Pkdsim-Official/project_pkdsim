using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations.Turning;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations.Strafing;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations
{
	public class UmbreonParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private UMParentMom_Jumping UMParentMom_MBA_Jumping;
		
		private UMParentMom_Running UMParentMom_MBA_Running;

		private UMParentMom_Turning UMParentMom_MBA_Turning;

		private UMParentMom_Strafing UMParentMom_MBA_Strafe;

		public void UMParentMom_MovementAnimatorController()
		{
			UMParentMom_MBA_Running.UMParentMom_RunningController();

			UMParentMom_MBA_Jumping.UMParentMom_JumpingController();

			UMParentMom_MBA_Turning.UMParentMom_TurningController();	

			UMParentMom_MBA_Strafe.UMParentMom_StrafingController();
		}	
	}
}