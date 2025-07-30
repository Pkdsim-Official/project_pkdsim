using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.Dad.movementbasedanimations
{
	public class NoivernParentDad_MovementAnimatorController : MonoBehaviour
	{
		private NOIParentDad_Jumping Noivern_MBA_Jumping;

		private NOIParentDad_Running Noivern_MBA_Running;


		private NOIParentDad_Turning Noivern_MBA_Turning;

		private NOIParentDad_Strafing Noivern_MBA_Strafe;

		public void NOIParentDad_MovementAnimatorController()
		{
			Noivern_MBA_Running.NOIParentDad_RunningController();

			Noivern_MBA_Jumping.NOIParentDad_JumpingController();

			Noivern_MBA_Turning.NOIParentDad_TurningController();

			Noivern_MBA_Strafe.NOIParentDad_StrafingController();
		}
	}
}