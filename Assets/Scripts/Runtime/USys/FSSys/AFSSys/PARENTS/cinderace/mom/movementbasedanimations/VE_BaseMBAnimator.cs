using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.movementbasedanimations.Jumping;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.movementbasedanimations.Running;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.movementbasedanimations.Strafing;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Mom.movementbasedanimations
{
	public class CinderaceParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private CParentMom_Jumping C_MBA_Jumping;
		
		private CParentMom_Running C_MBA_Running;


		private CParentMom_Turning C_MBA_Turning;

		private CParentMom_Strafing C_MBA_Strafe;

		public void CParentMom_MovementAnimatorController()
		{
			C_MBA_Running.CParentMom_RunningController();

			C_MBA_Jumping.CParentMom_JumpingController();

			C_MBA_Turning.CParentMom_TurningController();	

			C_MBA_Strafe.CParentMom_StrafingController();
		}
	}
}