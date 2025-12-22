using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.movementbasedanimations.Jumping;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.movementbasedanimations.Running;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.movementbasedanimations.Strafing;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.movementbasedanimations
{
	public class VespiquenParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private VEParentDad_Jumping VE_MBA_Jumping;
		
		private VEParentDad_Running VE_MBA_Running;


		private VEParentDad_Turning VE_MBA_Turning;

		private VEParentDad_Strafing VE_MBA_Strafe;

		public void VEParentDad_MovementAnimatorController()
		{
			VE_MBA_Running.VEParentDad_RunningController();

			VE_MBA_Jumping.VEParentDad_JumpingController();

			VE_MBA_Turning.VEParentDad_TurningController();	

			VE_MBA_Strafe.VEParentDad_StrafingController();
		}
	}
}