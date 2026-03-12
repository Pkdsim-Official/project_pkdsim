using Project_Pkdsim.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Lunala.Mom.movementbasedanimations
{
	public class LunalaParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private LUNAParentMom_Jumping LUNA_MBA_Jumping;
		
		private LUNAParentMom_Running LUNA_MBA_Running;

		private LUNAParentMom_Turning LUNA_MBA_Turning;

		private LUNAParentMom_Strafing LUNA_MBA_Strafe;

		public void LUNAParentMom_MovementAnimatorController()
		{
			LUNA_MBA_Running.LUNAParentMom_RunningController();

			LUNA_MBA_Jumping.LUNAParentMom_JumpingController();

			LUNA_MBA_Turning.LUNAParentMom_TurningController();	

			LUNA_MBA_Strafe.LUNAParentMom_StrafingController();
		}
	}
}