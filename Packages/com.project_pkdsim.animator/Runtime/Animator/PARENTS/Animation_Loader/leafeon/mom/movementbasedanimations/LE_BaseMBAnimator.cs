using  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations.Strafing;
using  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations.Jumping;
using  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations.Running;
using  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations
{
	public class LeafeonParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private LEParentMom_Jumping LEParent_MBA_Jumping;
		
		private LEParentMom_Running LEParent_MBA_Running;

		private LEParentMom_Turning LEParent_MBA_Turning;

		private LEParentMom_Strafing LEParent_MBA_Strafe;

		private void LEParent_MovementAnimatorController()
		{
			LEParent_MBA_Running.LEParentMom_RunningController();

			LEParent_MBA_Jumping.LEParentMom_JumpingController();

			LEParent_MBA_Turning.LEParentMom_TurningController();	

			LEParent_MBA_Strafe.LEParentMom_StrafingController();
		}
	}
}