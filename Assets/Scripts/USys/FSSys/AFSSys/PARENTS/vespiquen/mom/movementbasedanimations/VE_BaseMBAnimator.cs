using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations
{
	public class VespiquenParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private VEParentMom_Jumping VE_MBA_Jumping;
		
		private VEParentMom_Running VE_MBA_Running;


		private VEParentMom_Turning VE_MBA_Turning;

		private VEParentMom_Strafing VE_MBA_Strafe;

		public void VEParentMom_MovementAnimatorController()
		{
			VE_MBA_Running.VEParentMom_RunningController();

			VE_MBA_Jumping.VEParentMom_JumpingController();

			VE_MBA_Turning.VEParentMom_TurningController();	

			VE_MBA_Strafe.VEParentMom_StrafingController();
		}
	}
}