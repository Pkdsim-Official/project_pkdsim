using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Mom.movementbasedanimations
{
	public class DragapultParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private DRParentMom_Jumping DRParentMom_MBA_Jumping;
		
		private DRParentMom_Running DRParentMom_MBA_Running;


		private DRParentMom_Turning DRParentMom_MBA_Turning;

		private DRParentMom_Strafing DRParentMom_MBA_Strafe;

		public void DRParentMom_MovementAnimatorController()
		{
			DRParentMom_MBA_Running.DRParentMom_RunningController();

			DRParentMom_MBA_Jumping.DRParentMom_JumpingController();

			DRParentMom_MBA_Turning.DRParentMom_TurningController();	

			DRParentMom_MBA_Strafe.DRParentMom_StrafingController();
		}
	}
}