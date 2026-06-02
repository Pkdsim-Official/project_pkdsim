using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.Dad.movementbasedanimations
{
	public class NoivernParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private NOIParent_Jumping NoivernParentDad_MBA_Jumping;
		
		private NOIParent_Running NoivernParentDad_MBA_Running;


		private NOIParent_Turning NoivernParentDad_MBA_Turning;

		private NOIParent_Strafing NoivernParentDad_MBA_Strafe;

		public void NOIMovementAnimatorController()
		{
			NoivernParentDad_MBA_Running.NOIParent_RunningController();

			NoivernParentDad_MBA_Jumping.NOIParent_JumpingController();

			NoivernParentDad_MBA_Turning.NOIParent_TurningController();	

			NoivernParentDad_MBA_Strafe.NOIParent_StrafingController();
		}
	}
}