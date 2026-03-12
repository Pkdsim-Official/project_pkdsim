using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations.Jumping;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations.Running;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations.Strafing;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations
{
	public class DragapultParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private DRParentMom_Jumping DR_MBA_Jumping;
		
		private DRParentMom_Running DR_MBA_Running;


		private DRParentMom_Turning DR_MBA_Turning;

		private DRParentMom_Strafing DR_MBA_Strafe;

		public void DRParentMom_MovementAnimatorController()
		{
			DR_MBA_Running.DRParentMom_RunningController();

			DR_MBA_Jumping.DRParentMom_JumpingController();

			DR_MBA_Turning.DRParentMom_TurningController();	

			DR_MBA_Strafe.DRParentMom_StrafingController();
		}
	}
}