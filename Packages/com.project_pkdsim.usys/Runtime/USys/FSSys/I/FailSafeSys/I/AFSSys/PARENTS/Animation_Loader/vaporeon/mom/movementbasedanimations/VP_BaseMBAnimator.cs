using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations
{
	public class VaporeonParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private VPParentMom_Jumping VPParentMom_MBA_Jumping;
		
		private VPParentMom_Running VPParentMom_MBA_Running;

		private VPParentMom_Turning VPParentMom_MBA_Turning;

		private VPParentMom_Strafing VPParentMom_MBA_Strafe;

		public void VPParentMom_MovementAnimatorController()
		{
			VPParentMom_MBA_Running.VPParentMom_RunningController();

			VPParentMom_MBA_Jumping.VPParentMom_JumpingController();

			VPParentMom_MBA_Turning.VPParentMom_TurningController();	

			VPParentMom_MBA_Strafe.VPParentMom_StrafingController();
		}
	}
}