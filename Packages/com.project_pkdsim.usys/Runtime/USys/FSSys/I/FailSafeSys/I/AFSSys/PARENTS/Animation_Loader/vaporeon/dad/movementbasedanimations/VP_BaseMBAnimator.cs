using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vaporeon.Dad.movementbasedanimations
{
	public class VaporeonParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private VPParentDad_Jumping VPParentDad_MBA_Jumping;
		
		private VPParentDad_Running VPParentDad_MBA_Running;

		private VPParentDad_Turning VPParentDad_MBA_Turning;

		private VPParentDad_Strafing VPParentDad_MBA_Strafe;

		public void VPParentDad_MovementAnimatorController()
		{
			VPParentDad_MBA_Running.VPParentDad_RunningController();

			VPParentDad_MBA_Jumping.VPParentDad_JumpingController();

			VPParentDad_MBA_Turning.VPParentDad_TurningController();	

			VPParentDad_MBA_Strafe.VPParentDad_StrafingController();
		}
	}
}