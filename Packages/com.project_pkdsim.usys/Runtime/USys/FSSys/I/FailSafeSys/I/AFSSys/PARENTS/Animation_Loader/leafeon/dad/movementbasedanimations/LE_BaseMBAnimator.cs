using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations
{
	public class LeafeonParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private LEParentDad_Jumping LE_MBA_Jumping;
		
		private LEParentDad_Running LE_MBA_Running;

		private LEParentDad_Turning LE_MBA_Turning;

		private LEParentDad_Strafing LE_MBA_Strafe;

		public void LEParentDad_MovementAnimatorController()
		{
			LE_MBA_Running.LEParentDad_RunningController();

			LE_MBA_Jumping.LEParentDad_JumpingController();

			LE_MBA_Turning.LEParentDad_TurningController();	

			LE_MBA_Strafe.LEParentDad_StrafingController();
		}
	}
}