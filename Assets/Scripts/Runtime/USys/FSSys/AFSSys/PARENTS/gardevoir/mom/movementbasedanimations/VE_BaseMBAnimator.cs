using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.movementbasedanimations.Jumping;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.movementbasedanimations.Running;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.movementbasedanimations.Strafing;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.movementbasedanimations
{
	public class GardevoirParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private GARDParentMom_Jumping GARD_MBA_Jumping;
		
		private GARDParentMom_Running GARD_MBA_Running;


		private GARDParentMom_Turning GARD_MBA_Turning;

		private GARDParentMom_Strafing GARD_MBA_Strafe;

		public void GARDParentMom_MovementAnimatorController()
		{
			GARD_MBA_Running.GARDParentMom_RunningController();

			GARD_MBA_Jumping.GARDParentMom_JumpingController();

			GARD_MBA_Turning.GARDParentMom_TurningController();	

			GARD_MBA_Strafe.GARDParentMom_StrafingController();
		}
	}
}