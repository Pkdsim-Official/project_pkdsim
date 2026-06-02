using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.movementbasedanimations
{
	public class MeowscaradaParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private MEOWParentMom_Parent_Jumping MeowscaradaParentMom_MBA_Jumping;
		
		private MEOWParentMom_Parent_Running MeowscaradaParentMom_MBA_Running;


		private MEOWParentMom_Parent_Turning MeowscaradaParentMom_MBA_Turning;

		private MEOWParentMom_Parent_Strafing MeowscaradaParentMom_MBA_Strafe;

		public void MEOWParentMom_MovementAnimatorController()
		{
			MeowscaradaParentMom_MBA_Running.MEOWParentMom_Parent_RunningController();

			MeowscaradaParentMom_MBA_Jumping.MEOWParentMom_Parent_JumpingController();

			MeowscaradaParentMom_MBA_Turning.MEOWParentMom_Parent_TurningController();	

			MeowscaradaParentMom_MBA_Strafe.MEOWParentMom_Parent_StrafingController();
		}
	}
}