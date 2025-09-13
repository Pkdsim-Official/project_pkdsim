using project_pkdsim.ANIMATOR.Parents.Noivern.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Noivern.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Noivern.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Noivern.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.movementbasedanimations
{
	public class NoivernParent_AnimatorBaseMovementController : MonoBehaviour 
	{
		private NOIParent_Jumping Noivern_MBA_Jumping;
		
		private NOIParent_Running Noivern_MBA_Running;


		private NOIParent_Turning Noivern_MBA_Turning;

		private NOIParent_Strafing Noivern_MBA_Strafe;

		public void NOIMovementAnimatorController()
		{
			Noivern_MBA_Running.NOIParent_RunningController();

			Noivern_MBA_Jumping.NOIParent_JumpingController();

			Noivern_MBA_Turning.NOIParent_TurningController();	

			Noivern_MBA_Strafe.NOIParent_StrafingController();
		}
	}
}