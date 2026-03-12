using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations.Jumping;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations.Running;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations.Strafing;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Beedrill.Dad.movementbasedanimations
{
	public class BeedrillParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private BEParentDad_Jumping Beedrill_MBA_Jumping;
		
		private BEParentDad_Running Beedrill_MBA_Running;


		private BEParentDad_Turning Beedrill_MBA_Turning;

		private BEParentDad_Strafing Beedrill_MBA_Strafe;

		public void BE_MovementAnimatorController()
		{
			Beedrill_MBA_Running.BEParentDad_RunningController();

			Beedrill_MBA_Jumping.BEParentDad_JumpingController();

			Beedrill_MBA_Turning.BEParentDad_TurningController();	

			Beedrill_MBA_Strafe.BEParentDad_StrafingController();
		}
	}
}