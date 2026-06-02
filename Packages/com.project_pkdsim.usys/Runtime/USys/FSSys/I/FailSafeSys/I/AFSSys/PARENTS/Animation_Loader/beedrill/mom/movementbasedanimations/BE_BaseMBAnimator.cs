using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Mom.movementbasedanimations
{
	public class BeedrillParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private BEParent_Jumping BeedrillParentMom_MBA_Jumping;
		
		private BEParent_Running BeedrillParentMom_MBA_Running;


		private BEParent_Turning BeedrillParentMom_MBA_Turning;

		private BEParent_Strafing BeedrillParentMom_MBA_Strafe;

		public void BE_MovementAnimatorController()
		{
			BeedrillParentMom_MBA_Running.BEParent_RunningController();

			BeedrillParentMom_MBA_Jumping.BEParent_JumpingController();

			BeedrillParentMom_MBA_Turning.BEParent_TurningController();	

			BeedrillParentMom_MBA_Strafe.BEParent_StrafingController();
		}
	}
}