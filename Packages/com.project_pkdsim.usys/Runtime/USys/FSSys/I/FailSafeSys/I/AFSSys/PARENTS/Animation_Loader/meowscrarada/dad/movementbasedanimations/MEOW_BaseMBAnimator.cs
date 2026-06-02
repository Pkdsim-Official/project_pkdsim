using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.movementbasedanimations
{
	public class MeowscaradaParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private MEOWParentDad_Parent_Jumping MeowscaradaParentDad_MBA_Jumping;
		
		private MEOWParentDad_Parent_Running MeowscaradaParentDad_MBA_Running;


		private MEOWParentDad_Parent_Turning MeowscaradaParentDad_MBA_Turning;

		private MEOWParentDad_Parent_Strafing MeowscaradaParentDad_MBA_Strafe;

		public void MEOWParentDad_MovementAnimatorController()
		{
			MeowscaradaParentDad_MBA_Running.MEOWParentDad_Parent_RunningController();

			MeowscaradaParentDad_MBA_Jumping.MEOWParentDad_Parent_JumpingController();

			MeowscaradaParentDad_MBA_Turning.MEOWParentDad_Parent_TurningController();	

			MeowscaradaParentDad_MBA_Strafe.MEOWParentDad_Parent_StrafingController();
		}
	}
}