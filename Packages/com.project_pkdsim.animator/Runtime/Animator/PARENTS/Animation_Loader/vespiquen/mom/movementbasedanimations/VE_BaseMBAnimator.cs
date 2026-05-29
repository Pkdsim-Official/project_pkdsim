using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Vespiquen.Mom.movementbasedanimations
{
	public class VespiquenParent_AnimatorMovementController : MonoBehaviour 
	{
		private VEParent_Jumping VE_MBA_Jumping;
		
		private VEParent_Running VE_MBA_Running;


		private VEParent_Turning VE_MBA_Turning;

		private VEParent_Strafing VE_MBA_Strafe;

		public void VEMovementAnimatorController()
		{
			VE_MBA_Running.VEParent_RunningController();

			VE_MBA_Jumping.VEParent_JumpingController();

			VE_MBA_Turning.VEParent_TurningController();	

			VE_MBA_Strafe.VEParent_StrafingController();
		}
	}
}