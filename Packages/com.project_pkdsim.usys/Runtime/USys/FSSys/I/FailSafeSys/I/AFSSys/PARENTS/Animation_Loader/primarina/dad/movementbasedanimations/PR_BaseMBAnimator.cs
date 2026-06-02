using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Dad.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Dad.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Dad.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Dad.movementbasedanimations
{
	public class PrimarinaParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private PRParent_Jumping PrimarinaParentDad_MBA_Jumping;
		
		private PRParent_Running PrimarinaParentDad_MBA_Running;


		private PRParent_Turning PrimarinaParentDad_MBA_Turning;

		private PRParent_Strafing PrimarinaParentDad_MBA_Strafe;

		public void PRMovementAnimatorController()
		{
			PrimarinaParentDad_MBA_Running.PRParent_RunningController();

			PrimarinaParentDad_MBA_Jumping.PRParent_JumpingController();

			PrimarinaParentDad_MBA_Turning.PRParent_TurningController();	

			PrimarinaParentDad_MBA_Strafe.PRParent_StrafingController();
		}
	}
}