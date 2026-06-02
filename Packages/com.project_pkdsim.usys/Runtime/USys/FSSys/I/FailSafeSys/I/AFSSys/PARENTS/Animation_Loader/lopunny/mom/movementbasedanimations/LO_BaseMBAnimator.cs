using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations.Jumping;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations.Running;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations.Strafing;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations
{
	public class LopunnyParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private LOParentMom_Jumping Lopunny_MBA_Jumping;
		
		private LOParentMom_Running Lopunny_MBA_Running;

		private LOParentMom_Turning Lopunny_MBA_Turning;

		private LOParentMom_Strafing Lopunny_MBA_Strafe;

		public void LOParentMom_MovementAnimatorController()
		{
			Lopunny_MBA_Running.LOParentMom_RunningController();

			Lopunny_MBA_Jumping.LOParentMom_JumpingController();

			Lopunny_MBA_Turning.LOParentMom_TurningController();	

			Lopunny_MBA_Strafe.LOParentMom_StrafingController();
		}
	}
}