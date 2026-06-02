using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.movementbasedanimations.Turning;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.movementbasedanimations.Strafing;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.movementbasedanimations
{
	public class UmbreonParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private UMParentDad_Jumping UMParentDad_MBA_Jumping;
		
		private UMParentDad_Running UMParentDad_MBA_Running;

		private UMParentDad_Turning UMParentDad_MBA_Turning;

		private UMParentDad_Strafing UMParentDad_MBA_Strafe;

		public void UMParentDad_MovementAnimatorController()
		{
			UMParentDad_MBA_Running.UMParentDad_RunningController();

			UMParentDad_MBA_Jumping.UMParentDad_JumpingController();

			UMParentDad_MBA_Turning.UMParentDad_TurningController();	

			UMParentDad_MBA_Strafe.UMParentDad_StrafingController();
		}	
	}
}