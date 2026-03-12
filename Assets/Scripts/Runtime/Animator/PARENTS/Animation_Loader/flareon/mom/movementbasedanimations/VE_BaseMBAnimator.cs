using Project_Pkdsim.ANIMATOR.Parents.Flareon.Mom.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Parents.Flareon.Mom.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Parents.Flareon.Mom.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Parents.Flareon.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Flareon.Mom.movementbasedanimations
{
	public class FlareonParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private FLParentMom_Jumping FL_MBA_Jumping;
		
		private FLParentMom_Running FL_MBA_Running;


		private FLParentMom_Turning FL_MBA_Turning;

		private FLParentMom_Strafing FL_MBA_Strafe;

		public void FLParentMom_MovementAnimatorController()
		{
			FL_MBA_Running.FLParentMom_RunningController();

			FL_MBA_Jumping.FLParentMom_JumpingController();

			FL_MBA_Turning.FLParentMom_TurningController();	

			FL_MBA_Strafe.FLParentMom_StrafingController();
		}
	}
}