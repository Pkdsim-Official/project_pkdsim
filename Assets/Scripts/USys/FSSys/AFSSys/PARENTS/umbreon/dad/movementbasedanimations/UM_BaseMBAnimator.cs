using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.movementbasedanimations.Jumping;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.movementbasedanimations.Turning;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.movementbasedanimations.Running;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.movementbasedanimations.Strafing;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Umbreon.Dad.movementbasedanimations
{
	public class UmbreonParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private UMParentDad_Jumping UM_MBA_Jumping;
		
		private UMParentDad_Running UM_MBA_Running;

		private UMParentDad_Turning UM_MBA_Turning;

		private UMParentDad_Strafing UM_MBA_Strafe;

		public void UMParentDad_MovementAnimatorController()
		{
			UM_MBA_Running.UMParentDad_RunningController();

			UM_MBA_Jumping.UMParentDad_JumpingController();

			UM_MBA_Turning.UMParentDad_TurningController();	

			UM_MBA_Strafe.UMParentDad_StrafingController();
		}	
	}
}