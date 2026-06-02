using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Dad.movementbasedanimations
{
	public class LopunnyParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private LOParentDad_Jumping Lopunny_MBA_Jumping;
		
		private LOParentDad_Running Lopunny_MBA_Running;


		private LOParentDad_Turning Lopunny_MBA_Turning;

		private LOParentDad_Strafing Lopunny_MBA_Strafe;

		public void LOParentDad_MovementAnimatorController()
		{
			Lopunny_MBA_Running.LOParentDad_RunningController();

			Lopunny_MBA_Jumping.LOParentDad_JumpingController();

			Lopunny_MBA_Turning.LOParentDad_TurningController();	

			Lopunny_MBA_Strafe.LOParentDad_StrafingController();
		}
	}
}