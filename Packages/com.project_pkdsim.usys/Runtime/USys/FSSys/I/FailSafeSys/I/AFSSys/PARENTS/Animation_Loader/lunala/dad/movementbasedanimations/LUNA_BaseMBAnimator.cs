using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.movementbasedanimations
{
	public class LunalaParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private LUNAParentDad_Jumping LunalaParentDad_MBA_Jumping;
		
		private LUNAParentDad_Running LunalaParentDad_MBA_Running;

		private LUNAParentDad_Turning LunalaParentDad_MBA_Turning;

		private LUNAParentDad_Strafing LunalaParentDad_MBA_Strafe;

		public void LUNAParentDad_MovementAnimatorController()
		{
			LunalaParentDad_MBA_Running.LUNAParentDad_RunningController();

			LunalaParentDad_MBA_Jumping.LUNAParentDad_JumpingController();

			LunalaParentDad_MBA_Turning.LUNAParentDad_TurningController();	

			LunalaParentDad_MBA_Strafe.LUNAParentDad_StrafingController();
		}
	}
}