using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Dad.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Dad.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Dad.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Dad.movementbasedanimations
{
	public class GardevoirParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private GARDParent_Jumping GardevoirParentDad_MBA_Jumping;
		
		private GARDParent_Running GardevoirParentDad_MBA_Running;


		private GARDParent_Turning GardevoirParentDad_MBA_Turning;

		private GARDParent_Strafing GardevoirParentDad_MBA_Strafe;

		public void GARDMovementAnimatorController()
		{
			GardevoirParentDad_MBA_Running.GARDParent_RunningController();

			GardevoirParentDad_MBA_Jumping.GARDParent_JumpingController();

			GardevoirParentDad_MBA_Turning.GARDParent_TurningController();	

			GardevoirParentDad_MBA_Strafe.GARDParent_StrafingController();
		}
	}
}