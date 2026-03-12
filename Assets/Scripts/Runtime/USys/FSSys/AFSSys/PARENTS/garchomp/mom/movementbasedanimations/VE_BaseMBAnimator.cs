using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.movementbasedanimations.Jumping;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.movementbasedanimations.Running;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.movementbasedanimations.Strafing;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.movementbasedanimations
{
	public class GarchompParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private GARCParentMom_Jumping GARC_MBA_Jumping;
		
		private GARCParentMom_Running GARC_MBA_Running;


		private GARCParentMom_Turning GARC_MBA_Turning;

		private GARCParentMom_Strafing GARC_MBA_Strafe;

		public void GARCParentMom_MovementAnimatorController()
		{
			GARC_MBA_Running.GARCParentMom_RunningController();

			GARC_MBA_Jumping.GARCParentMom_JumpingController();

			GARC_MBA_Turning.GARCParentMom_TurningController();	

			GARC_MBA_Strafe.GARCParentMom_StrafingController();
		}
	}
}