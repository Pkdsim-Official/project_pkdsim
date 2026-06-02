using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Mom.Mom.movementbasedanimations
{
	public class HattereneParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private HATParentMom_Jumping HattereneParentMom_MBA_Jumping;
		
		private HATParentMom_Running HattereneParentMom_MBA_Running;


		private HATParentMom_Turning HattereneParentMom_MBA_Turning;

		private HATParentMom_Strafing HattereneParentMom_MBA_Strafe;

		public void HATParentMom_MovementAnimatorController()
		{
			HattereneParentMom_MBA_Running.HATParentMom_RunningController();

			HattereneParentMom_MBA_Jumping.HATParentMom_JumpingController();

			HattereneParentMom_MBA_Turning.HATParentMom_TurningController();	

			HattereneParentMom_MBA_Strafe.HATParentMom_StrafingController();
		}
	}
}