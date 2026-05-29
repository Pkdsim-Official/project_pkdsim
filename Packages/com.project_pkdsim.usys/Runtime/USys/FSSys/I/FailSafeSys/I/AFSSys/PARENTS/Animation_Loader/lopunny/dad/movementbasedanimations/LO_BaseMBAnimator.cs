using project_pkdsim.ANIMATOR.Parents.Lopunny.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Lopunny.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Lopunny.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Lopunny.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lopunny.movementbasedanimations
{
	public class LopunnyParent_AnimatorMovementController : MonoBehaviour 
	{
		private LOParent_Jumping Lopunny_MBA_Jumping;
		
		private LOParent_Running Lopunny_MBA_Running;


		private LOParent_Turning Lopunny_MBA_Turning;

		private LOParent_Strafing Lopunny_MBA_Strafe;

		public void LOMovementAnimatorController()
		{
			Lopunny_MBA_Running.LOParent_RunningController();

			Lopunny_MBA_Jumping.LOParent_JumpingController();

			Lopunny_MBA_Turning.LOParent_TurningController();	

			Lopunny_MBA_Strafe.LOParent_StrafingController();
		}
	}
}