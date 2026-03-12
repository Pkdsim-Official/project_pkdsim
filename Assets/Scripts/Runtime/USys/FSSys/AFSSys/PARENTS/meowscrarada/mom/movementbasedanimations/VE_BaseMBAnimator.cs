using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.movementbasedanimations.Jumping;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.movementbasedanimations.Running;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.movementbasedanimations.Strafing;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.movementbasedanimations
{
	public class MeowscaradaParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private MEOWParentMom_Jumping MEOW_MBA_Jumping;
		
		private MEOWParentMom_Running MEOW_MBA_Running;


		private MEOWParentMom_Turning MEOW_MBA_Turning;

		private MEOWParentMom_Strafing MEOW_MBA_Strafe;

		public void MEOWParentMom_MovementAnimatorController()
		{
			MEOW_MBA_Running.MEOWParentMom_RunningController();

			MEOW_MBA_Jumping.MEOWParentMom_JumpingController();

			MEOW_MBA_Turning.MEOWParentMom_TurningController();	

			MEOW_MBA_Strafe.MEOWParentMom_StrafingController();
		}
	}
}