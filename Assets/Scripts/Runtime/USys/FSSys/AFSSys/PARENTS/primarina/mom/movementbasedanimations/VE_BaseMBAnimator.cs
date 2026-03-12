using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.movementbasedanimations.Jumping;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.movementbasedanimations.Running;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.movementbasedanimations.Strafing;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.movementbasedanimations
{
	public class PrimarinaParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private PRParentMom_Jumping PR_MBA_Jumping;
		
		private PRParentMom_Running PR_MBA_Running;


		private PRParentMom_Turning PR_MBA_Turning;

		private PRParentMom_Strafing PR_MBA_Strafe;

		public void PRParentMom_MovementAnimatorController()
		{
			PR_MBA_Running.PRParentMom_RunningController();

			PR_MBA_Jumping.PRParentMom_JumpingController();

			PR_MBA_Turning.PRParentMom_TurningController();	

			PR_MBA_Strafe.PRParentMom_StrafingController();
		}
	}
}