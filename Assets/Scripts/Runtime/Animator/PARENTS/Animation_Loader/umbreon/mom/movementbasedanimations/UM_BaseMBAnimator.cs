using Project_Pkdsim.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations
{
	public class UmbreonParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private UMParentMom_Jumping UM_MBA_Jumping;
		
		private UMParentMom_Running UM_MBA_Running;


		private UMParentMom_Turning UM_MBA_Turning;

		private UMParentMom_Strafing UM_MBA_Strafe;

		public void UMParentMom_MovementAnimatorController()
		{
			UM_MBA_Running.UMParentMom_RunningController();

			UM_MBA_Jumping.UMParentMom_JumpingController();

			UM_MBA_Turning.UMParentMom_TurningController();	

			UM_MBA_Strafe.UMParentMom_StrafingController();
		}
	}
}