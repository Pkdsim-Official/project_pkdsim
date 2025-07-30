using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations
{
	public class LopunnyParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private LOParentMom_Jumping LO_MBA_Jumping;
		
		private LOParentMom_Running LO_MBA_Running;


		private LOParentMom_Turning LO_MBA_Turning;

		private LOParentMom_Strafing LO_MBA_Strafe;

		public void LOParentMom_MovementAnimatorController()
		{
			LO_MBA_Running.LOParentMom_RunningController();

			LO_MBA_Jumping.LOParentMom_JumpingController();

			LO_MBA_Turning.LOParentMom_TurningController();	

			LO_MBA_Strafe.LOParentMom_StrafingController();
		}
	}
}