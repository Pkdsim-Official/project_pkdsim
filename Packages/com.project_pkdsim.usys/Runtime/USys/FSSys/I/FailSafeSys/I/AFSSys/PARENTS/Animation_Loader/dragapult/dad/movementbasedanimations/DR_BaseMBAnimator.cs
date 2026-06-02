using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.movementbasedanimations
{
	public class DragapultParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private DRParentDad_Parent_Jumping DRParentDad_MBA_Jumping;
		
		private DRParentDad_Parent_Running DRParentDad_MBA_Running;


		private DRParentDad_Parent_Turning DRParentDad_MBA_Turning;

		private DRParentDad_Parent_Strafing DRParentDad_MBA_Strafe;

		public void DRParentDad_MovementAnimatorController()
		{
			DRParentDad_MBA_Running.DRParentDad_Parent_RunningController();

			DRParentDad_MBA_Jumping.DRParentDad_Parent_JumpingController();

			DRParentDad_MBA_Turning.DRParentDad_Parent_TurningController();	

			DRParentDad_MBA_Strafe.DRParentDad_Parent_StrafingController();
		}
	}
}