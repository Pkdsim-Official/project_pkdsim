using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations
{
	public class GlaceonParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private GLParentDad_Jumping GLParentDad_MBA_Jumping;
		
		private GLParentDad_Running GLParentDad_MBA_Running;

		private GLParentDad_Turning GLParentDad_MBA_Turning;

		private GLParentDad_Strafe GLParentDad_MBA_Strafe;

		public void GLParentDad_MovementAnimatorController()
		{
			GLParentDad_MBA_Running.GLParentDad_RunningController();

			GLParentDad_MBA_Jumping.GLParentDad_JumpingController();

			GLParentDad_MBA_Turning.GLParentDad_TurningController();	

			GLParentDad_MBA_Strafe.GLParentDad_StrafingController();
		}
	}
}