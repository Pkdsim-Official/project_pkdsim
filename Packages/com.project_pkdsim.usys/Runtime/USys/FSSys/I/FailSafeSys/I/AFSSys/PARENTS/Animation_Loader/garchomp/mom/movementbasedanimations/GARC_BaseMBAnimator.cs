using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.movementbasedanimations
{
	public class GarchompParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private GARCParentMom_Jumping Garchomp_MBA_Jumping;
		
		private GARCParentMom_Running Garchomp_MBA_Running;


		private GARCParentMom_Turning Garchomp_MBA_Turning;

		private GARCParentMom_Strafing Garchomp_MBA_Strafe;

		public void GARCParentMom_MovementAnimatorController()
		{
			Garchomp_MBA_Running.GARCParentMom_RunningController();

			Garchomp_MBA_Jumping.GARCParentMom_JumpingController();

			Garchomp_MBA_Turning.GARCParentMom_TurningController();	

			Garchomp_MBA_Strafe.GARCParentMom_StrafingController();
		}
	}
}