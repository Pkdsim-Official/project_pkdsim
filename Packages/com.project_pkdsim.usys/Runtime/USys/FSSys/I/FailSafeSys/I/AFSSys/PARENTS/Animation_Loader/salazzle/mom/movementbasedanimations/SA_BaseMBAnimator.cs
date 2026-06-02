using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.movementbasedanimations
{
	public class SalazzLEParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private SAParent_Jumping SA_MBA_Jumping;
		
		private SAParent_Running SA_MBA_Running;


		private SAParent_Turning SA_MBA_Turning;

		private SAParent_Strafing SA_MBA_Strafe;

		public void SA_MovementAnimatorController()
		{
			SA_MBA_Running.SAParent_RunningController();

			SA_MBA_Jumping.SAParent_JumpingController();

			SA_MBA_Turning.SAParent_TurningController();	

			SA_MBA_Strafe.SAParent_StrafingController();
		}
	}
}