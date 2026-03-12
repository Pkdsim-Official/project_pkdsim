using Project_Pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations
{
	public class LeafeonParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private LEParentMom_Jumping LE_MBA_Jumping;
		
		private LEParentMom_Running LE_MBA_Running;


		private LEParentMom_Turning LE_MBA_Turning;

		private LEParentMom_Strafing LE_MBA_Strafe;

		public void LEParentMom_MovementAnimatorController()
		{
			LE_MBA_Running.LEParentMom_RunningController();

			LE_MBA_Jumping.LEParentMom_JumpingController();

			LE_MBA_Turning.LEParentMom_TurningController();	

			LE_MBA_Strafe.LEParentMom_StrafingController();
		}
	}
}