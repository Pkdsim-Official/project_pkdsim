using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations
{
	public class VespiquenParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private VEParentMom_Jumping VEParentMom_MBA_Jumping;
		
		private VEParentMom_Running VEParentMom_MBA_Running;


		private VEParentMom_Turning VEParentMom_MBA_Turning;

		private VEParentMom_Strafing VEParentMom_MBA_Strafe;

		public void VEParentMom_MovementAnimatorController()
		{
			VEParentMom_MBA_Running.VEParentMom_RunningController();

			VEParentMom_MBA_Jumping.VEParentMom_JumpingController();

			VEParentMom_MBA_Turning.VEParentMom_TurningController();	

			VEParentMom_MBA_Strafe.VEParentMom_StrafingController();
		}
	}
}