using project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vaporeon.Mom.movementbasedanimations
{
	public class VaporeonParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private VPParentMom_Jumping VP_MBA_Jumping;
		
		private VPParentMom_Running VP_MBA_Running;


		private VPParentMom_Turning VP_MBA_Turning;

		private VPParentMom_Strafing VP_MBA_Strafe;

		public void VPParentMom_MovementAnimatorController()
		{
			VP_MBA_Running.VPParentMom_RunningController();

			VP_MBA_Jumping.VPParentMom_JumpingController();

			VP_MBA_Turning.VPParentMom_TurningController();	

			VP_MBA_Strafe.VPParentMom_StrafingController();
		}
	}
}