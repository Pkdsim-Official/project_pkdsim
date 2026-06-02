using project_pkdsim.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lopunny.Mom.movementbasedanimations
{
	public class LopunnyParent_MovementAnimatorController : MonoBehaviour 
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