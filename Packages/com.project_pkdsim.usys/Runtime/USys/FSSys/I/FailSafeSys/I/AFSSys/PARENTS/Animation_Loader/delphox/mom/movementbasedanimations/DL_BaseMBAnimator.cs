using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.Mom.movementbasedanimations
{
	public class DelphoxParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private DLParent_Jumping DL_MBA_Jumping;
		
		private DLParent_Running DL_MBA_Running;


		private DLParent_Turning DL_MBA_Turning;

		private DLParent_Strafing DL_MBA_Strafe;

		public void DLMovementAnimatorController()
		{
			DL_MBA_Running.DLParent_RunningController();

			DL_MBA_Jumping.DLParent_JumpingController();

			DL_MBA_Turning.DLParent_TurningController();	

			DL_MBA_Strafe.DLParent_StrafingController();
		}
	}
}