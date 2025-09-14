using project_pkdsim.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations
{
	public class NoivernParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private NOIParentMom_Jumping NOI_MBA_Jumping;
		
		private NOIParentMom_Running NOI_MBA_Running;


		private NOIParentMom_Turning NOI_MBA_Turning;

		private NOIParentMom_Strafing NOI_MBA_Strafe;

		public void NOIParentMom_MovementAnimatorController()
		{
			NOI_MBA_Running.NOIParentMom_RunningController();

			NOI_MBA_Jumping.NOIParentMom_JumpingController();

			NOI_MBA_Turning.NOIParentMom_TurningController();	

			NOI_MBA_Strafe.NOIParentMom_StrafingController();
		}
	}
}