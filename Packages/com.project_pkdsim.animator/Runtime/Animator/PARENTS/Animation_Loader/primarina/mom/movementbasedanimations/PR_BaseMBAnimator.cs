using project_pkdsim.ANIMATOR.Parents.Primarina.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Primarina.Mom.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Primarina.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Primarina.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Primarina.Mom.movementbasedanimations
{
	public class PrimarinaParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private PRParent_Jumping PrimarinaParentMom_MBA_Jumping;
		
		private PRParent_Running PrimarinaParentMom_MBA_Running;


		private PRParent_Turning PrimarinaParentMom_MBA_Turning;

		private PRParent_Strafing PrimarinaParentMom_MBA_Strafe;

		public void PR_MovementAnimatorController()
		{
			PrimarinaParentMom_MBA_Running.PRParent_RunningController();

			PrimarinaParentMom_MBA_Jumping.PRParent_JumpingController();

			PrimarinaParentMom_MBA_Turning.PRParent_TurningController();	

			PrimarinaParentMom_MBA_Strafe.PRParent_StrafingController();
		}
	}
}