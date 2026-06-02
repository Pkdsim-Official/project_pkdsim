using project_pkdsim.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Leafeon.Dad.movementbasedanimations
{
	public class LeafeonParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private LEParentDad_Jumping LEParent_MBA_Jumping;
		
		private LEParentDad_Running LEParent_MBA_Running;

		private LEParentDad_Turning LEParent_MBA_Turning;

		private LEParentDad_Strafing LEParent_MBA_Strafe;

		public void LEParentDad_MovementAnimatorController()
		{
			LEParent_MBA_Running.LEParentDad_RunningController();

			LEParent_MBA_Jumping.LEParentDad_JumpingController();

			LEParent_MBA_Turning.LEParentDad_TurningController();	

			LEParent_MBA_Strafe.LEParentDad_StrafingController();
		}
	}
}