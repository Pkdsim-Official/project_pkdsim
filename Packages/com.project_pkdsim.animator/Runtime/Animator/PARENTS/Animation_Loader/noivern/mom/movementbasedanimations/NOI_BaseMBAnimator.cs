using project_pkdsim.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations
{
	public class NoivernParentMom_AnimatorMovementController : MonoBehaviour 
	{
		private NOIParent_Jumping NoivernParentMom_MBA_Jumping;
		
		private NOIParent_Running NoivernParentMom_MBA_Running;


		private NOIParent_Turning NoivernParentMom_MBA_Turning;

		private NOIParent_Strafing NoivernParentMom_MBA_Strafe;

		public void NOIMovementAnimatorController()
		{
			NoivernParentMom_MBA_Running.NOIParent_RunningController();

			NoivernParentMom_MBA_Jumping.NOIParent_JumpingController();

			NoivernParentMom_MBA_Turning.NOIParent_TurningController();	

			NoivernParentMom_MBA_Strafe.NOIParent_StrafingController();
		}
	}
}