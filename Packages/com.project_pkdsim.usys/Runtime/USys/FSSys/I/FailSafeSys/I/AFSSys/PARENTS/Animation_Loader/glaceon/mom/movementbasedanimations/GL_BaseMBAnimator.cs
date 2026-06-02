using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations
{
	public class GlaceonParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private GLParentMom_Jumping GLParentMom_MBA_Jumping;
		
		private GLParentMom_Running GLParentMom_MBA_Running;

		private GLParentMom_Turning GLParentMom_MBA_Turning;

		private GLParentMom_Strafe GLParentMom_MBA_Strafe;

		public void GLParentMom_MovementAnimatorController()
		{
			GLParentMom_MBA_Running.GLParentMom_RunningController();

			GLParentMom_MBA_Jumping.GLParentMom_JumpingController();

			GLParentMom_MBA_Turning.GLParentMom_TurningController();	

			GLParentMom_MBA_Strafe.GLParentMom_StrafingController();
		}
	}
}