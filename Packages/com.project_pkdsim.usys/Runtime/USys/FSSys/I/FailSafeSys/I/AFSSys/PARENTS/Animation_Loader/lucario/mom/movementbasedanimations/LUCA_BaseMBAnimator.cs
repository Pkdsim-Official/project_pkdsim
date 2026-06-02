using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations
{
	public class LucarioParent_MovementAnimatorController : MonoBehaviour 
	{
		private LUCAParentMom_Jumping Lucario_MBA_Jumping;
		
		private LUCAParentMom_Running Lucario_MBA_Running;


		private LUCAParentMom_Turning Lucario_MBA_Turning;

		private LUCAParentMom_Strafing Lucario_MBA_Strafe;

		public void LUCAParentMom_MovementAnimatorController()
		{
			Lucario_MBA_Running.LUCAParentMom_RunningController();

			Lucario_MBA_Jumping.LUCAParentMom_JumpingController();

			Lucario_MBA_Turning.LUCAParentMom_TurningController();	

			Lucario_MBA_Strafe.LUCAParentMom_StrafingController();
		}
	}
}