using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.movementbasedanimations
{
	public class AbsolParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private ABParentDad_Jumping AB_MBA_Jumping;
		
		private ABParentDad_Running AB_MBA_Running;


		private ABParentDad_Turning AB_MBA_Turning;

		private ABParentDad_Strafing AB_MBA_Strafe;

		public void ABMovementAnimatorController()
		{
			AB_MBA_Running.ABParentDad_RunningController();

			AB_MBA_Jumping.ABParentDad_JumpingController();

			AB_MBA_Turning.ABParentDad_TurningController();	

			AB_MBA_Strafe.ABParentDad_StrafingController();
		}
	}
}