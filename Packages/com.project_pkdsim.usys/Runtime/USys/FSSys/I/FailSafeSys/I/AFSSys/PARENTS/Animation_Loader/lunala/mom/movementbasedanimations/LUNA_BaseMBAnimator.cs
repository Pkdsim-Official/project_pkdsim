using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations
{
	public class LunalaParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private LUNAParentDad_Jumping LunalaParentMom_MBA_Jumping;
		
		private LUNAParentDad_Running LunalaParentMom_MBA_Running;


		private LUNAParentDad_Turning LunalaParentMom_MBA_Turning;

		private LUNAParentDad_Strafing LunalaParentMom_MBA_Strafe;

		public void LUNAParentMom_MovementAnimatorController()
		{
			LunalaParentMom_MBA_Running.LUNAParentDad_RunningController();

			LunalaParentMom_MBA_Jumping.LUNAParentDad_JumpingController();

			LunalaParentMom_MBA_Turning.LUNAParentDad_TurningController();	

			LunalaParentMom_MBA_Strafe.LUNAParentDad_StrafingController();
		}
	}
}