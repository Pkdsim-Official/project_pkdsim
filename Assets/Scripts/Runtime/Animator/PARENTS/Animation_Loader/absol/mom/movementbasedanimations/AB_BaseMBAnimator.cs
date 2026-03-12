using Project_Pkdsim.ANIMATOR.Parents.Absol.Mom.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Parents.Absol.Mom.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Parents.Absol.Mom.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Parents.Absol.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Absol.Mom.movementbasedanimations
{
	public class AbsolParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private ABParentMom_Jumping AB_MBA_Jumping;
		
		private ABParentMom_Running AB_MBA_Running;


		private ABParentMom_Turning AB_MBA_Turning;

		private ABParentMom_Strafing AB_MBA_Strafe;

		public void ABParentMom_MovementAnimatorController()
		{
			AB_MBA_Running.ABParentMom_RunningController();

			AB_MBA_Jumping.ABParentMom_JumpingController();

			AB_MBA_Turning.ABParentMom_TurningController();	

			AB_MBA_Strafe.ABParentMom_StrafingController();
		}
	}
}