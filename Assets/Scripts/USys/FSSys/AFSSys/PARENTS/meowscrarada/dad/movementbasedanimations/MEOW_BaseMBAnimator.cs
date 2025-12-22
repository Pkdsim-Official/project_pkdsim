using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.movementbasedanimations.Jumping;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.movementbasedanimations.Running;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.movementbasedanimations.Strafing;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.movementbasedanimations
{
	public class MeowscaradaParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private MEOWParent_Jumping Meowscarada_MBA_Jumping;
		
		private MEOWParent_Running Meowscarada_MBA_Running;


		private MEOWParent_Turning Meowscarada_MBA_Turning;

		private MEOWParent_Strafing Meowscarada_MBA_Strafe;

		public void MEOWMovementAnimatorController()
		{
			Meowscarada_MBA_Running.MEOWParent_RunningController();

			Meowscarada_MBA_Jumping.MEOWParent_JumpingController();

			Meowscarada_MBA_Turning.MEOWParent_TurningController();	

			Meowscarada_MBA_Strafe.MEOWParent_StrafingController();
		}
	}
}