using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.movementbasedanimations.Jumping;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.movementbasedanimations.Running;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.movementbasedanimations.Strafing;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Dad.movementbasedanimations
{
	public class CinderaceParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private ParentDad_Jumping C_MBA_Jumping;
		
		private ParentDad_Running C_MBA_Running;


		private ParentDad_Turning C_MBA_Turning;

		private ParentDad_Strafing C_MBA_Strafe;

		public void CMovementAnimatorController()
		{
			C_MBA_Running.ParentDad_RunningController();

			C_MBA_Jumping.ParentDad_JumpingController();

			C_MBA_Turning.ParentDad_TurningController();	

			C_MBA_Strafe.ParentDad_StrafingController();
		}
	}
}