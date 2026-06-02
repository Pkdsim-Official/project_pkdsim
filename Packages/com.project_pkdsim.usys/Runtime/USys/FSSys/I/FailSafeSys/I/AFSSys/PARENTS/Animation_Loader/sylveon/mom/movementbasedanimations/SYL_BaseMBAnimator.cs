using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.movementbasedanimations
{
	public class SylveonParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private SYLParentMom_Jumping Sylveon_MBA_Jumping;
		
		private SYLParentMom_Running Sylveon_MBA_Running;

		private SYLParentMom_Turning Sylveon_MBA_Turning;

		private SYLParentMom_Strafing Sylveon_MBA_Strafe;

		public void SYLParentMom_MovementAnimatorController()
		{
			Sylveon_MBA_Running.SYLParentMom_RunningController();

			Sylveon_MBA_Jumping.SYLParentMom_JumpingController();

			Sylveon_MBA_Turning.SYLParentMom_TurningController();	

			Sylveon_MBA_Strafe.SYLParentMom_StrafingController();
		}	
	}
}