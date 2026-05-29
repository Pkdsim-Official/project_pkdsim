using  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations.Strafing;
using  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations.Jumping;
using  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations.Running;
using  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace  project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations
{
	public class LeafeonParent_AnimatorMovementController : MonoBehaviour 
	{
		private LEParent_Jumping LE_MBA_Jumping;
		
		private LEParent_Running LE_MBA_Running;

		private LEParent_Turning LE_MBA_Turning;

		private LEParent_Strafing LE_MBA_Strafe;

		private void LE_MovementAnimatorController()
		{
			LE_MBA_Running.LEParent_RunningController();

			LE_MBA_Jumping.LEParent_JumpingController();

			LE_MBA_Turning.LEParent_TurningController();	

			LE_MBA_Strafe.LEParent_StrafingController();
		}
	}
}