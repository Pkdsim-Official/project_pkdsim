using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations
{
	public class BeedrillParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private BEParent_Jumping BeedrillParentDad_MBA_Jumping;
		
		private BEParent_Running BeedrillParentDad_MBA_Running;


		private BEParent_Turning BeedrillParentDad_MBA_Turning;

		private BEParent_Strafing BeedrillParentDad_MBA_Strafe;

		public void BE_MovementAnimatorController()
		{
			BeedrillParentDad_MBA_Running.BEParent_RunningController();

			BeedrillParentDad_MBA_Jumping.BEParent_JumpingController();

			BeedrillParentDad_MBA_Turning.BEParent_TurningController();	

			BeedrillParentDad_MBA_Strafe.BEParent_StrafingController();
		}
	}
}