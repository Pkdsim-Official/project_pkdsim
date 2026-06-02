using project_pkdsim.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations
{
	public class BeedrillParent_MovementAnimatorController : MonoBehaviour 
	{
		private BEParent_Jumping Beedrill_MBA_Jumping;
		
		private BEParent_Running Beedrill_MBA_Running;


		private BEParent_Turning Beedrill_MBA_Turning;

		private BEParent_Strafing Beedrill_MBA_Strafe;

		public void BE_MovementAnimatorController()
		{
			Beedrill_MBA_Running.BEParent_RunningController();

			Beedrill_MBA_Jumping.BEParent_JumpingController();

			Beedrill_MBA_Turning.BEParent_TurningController();	

			Beedrill_MBA_Strafe.BEParent_StrafingController();
		}
	}
}