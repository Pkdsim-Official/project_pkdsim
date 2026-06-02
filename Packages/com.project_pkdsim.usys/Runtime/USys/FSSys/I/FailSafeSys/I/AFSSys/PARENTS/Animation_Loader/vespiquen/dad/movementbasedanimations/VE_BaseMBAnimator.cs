using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Vespiquen.Dad.movementbasedanimations
{
	public class VespiquenParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private VEParentDad_Jumping VEParentMom_MBA_Jumping;
		
		private VEParentDad_Running VEParentMom_MBA_Running;


		private VEParentDad_Turning VEParentMom_MBA_Turning;

		private VEParentDad_Strafing VEParentMom_MBA_Strafe;

		public void VEParentDad_MovementAnimatorController()
		{
			VEParentMom_MBA_Running.VEParentDad_RunningController();

			VEParentMom_MBA_Jumping.VEParentDad_JumpingController();

			VEParentMom_MBA_Turning.VEParentDad_TurningController();	

			VEParentMom_MBA_Strafe.VEParentDad_StrafingController();
		}
	}
}