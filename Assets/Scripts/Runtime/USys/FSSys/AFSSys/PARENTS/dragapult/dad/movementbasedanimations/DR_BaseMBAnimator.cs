using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.movementbasedanimations.Jumping;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.movementbasedanimations.Running;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.movementbasedanimations.Strafing;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.movementbasedanimations
{
	public class DragapultParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private DRParent_Jumping DR_MBA_Jumping;
		
		private DRParent_Running DR_MBA_Running;


		private DRParent_Turning DR_MBA_Turning;

		private DRParent_Strafing DR_MBA_Strafe;

		public void DRMovementAnimatorController()
		{
			DR_MBA_Running.DRParent_RunningController();

			DR_MBA_Jumping.DRParent_JumpingController();

			DR_MBA_Turning.DRParent_TurningController();	

			DR_MBA_Strafe.DRParent_StrafingController();
		}
	}
}