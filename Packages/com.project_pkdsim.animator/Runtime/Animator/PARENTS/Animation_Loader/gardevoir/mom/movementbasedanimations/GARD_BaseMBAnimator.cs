using project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Gardevoir.Mom.movementbasedanimations
{
	public class GardevoirParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private GARDParent_Jumping GardevoirParentMom_MBA_Jumping;
		
		private GARDParent_Running GardevoirParentMom_MBA_Running;


		private GARDParent_Turning GardevoirParentMom_MBA_Turning;

		private GARDParent_Strafing GardevoirParentMom_MBA_Strafe;

		public void GARDMovementAnimatorController()
		{
			GardevoirParentMom_MBA_Running.GARDParent_RunningController();

			GardevoirParentMom_MBA_Jumping.GARDParent_JumpingController();

			GardevoirParentMom_MBA_Turning.GARDParent_TurningController();	

			GardevoirParentMom_MBA_Strafe.GARDParent_StrafingController();
		}
	}
}