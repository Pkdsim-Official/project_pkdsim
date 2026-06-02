using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.movementbasedanimations
{
	public class CinderaceParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private CParent_Jumping C_MBA_Jumping;
		
		private CParent_Running C_MBA_Running;


		private CParent_Turning C_MBA_Turning;

		private CParent_Strafing C_MBA_Strafe;

		public void CMovementAnimatorController()
		{
			C_MBA_Running.CParent_RunningController();

			C_MBA_Jumping.CParent_JumpingController();

			C_MBA_Turning.CParent_TurningController();	

			C_MBA_Strafe.CParent_StrafingController();
		}
	}
}