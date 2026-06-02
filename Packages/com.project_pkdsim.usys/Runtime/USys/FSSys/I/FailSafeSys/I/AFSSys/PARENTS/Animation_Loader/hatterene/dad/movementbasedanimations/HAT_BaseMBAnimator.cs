using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Hatterene.Dad.movementbasedanimations
{
	public class HattereneParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private HATParentDad_Jumping HattereneParentDad_MBA_Jumping;
		
		private HATParentDad_Running HattereneParentDad_MBA_Running;


		private HATParentDad_Turning HattereneParentDad_MBA_Turning;

		private HATParentDad_Strafing HattereneParentDad_MBA_Strafe;

		public void HATParentDad_MovementAnimatorController()
		{
			HattereneParentDad_MBA_Running.HATParentDad_RunningController();

			HattereneParentDad_MBA_Jumping.HATParentDad_JumpingController();

			HattereneParentDad_MBA_Turning.HATParentDad_TurningController();	

			HattereneParentDad_MBA_Strafe.HATParentDad_StrafingController();
		}
	}
}