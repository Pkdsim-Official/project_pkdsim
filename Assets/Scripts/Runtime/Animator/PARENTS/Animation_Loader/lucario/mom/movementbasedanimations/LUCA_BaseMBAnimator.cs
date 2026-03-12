using Project_Pkdsim.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations
{
	public class LucarioParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private LUCAParentMom_Jumping LUCA_MBA_Jumping;
		
		private LUCAParentMom_Running LUCA_MBA_Running;


		private LUCAParentMom_Turning LUCA_MBA_Turning;

		private LUCAParentMom_Strafing LUCA_MBA_Strafe;

		public void LUCAParentMom_MovementAnimatorController()
		{
			LUCA_MBA_Running.LUCAParentMom_RunningController();

			LUCA_MBA_Jumping.LUCAParentMom_JumpingController();

			LUCA_MBA_Turning.LUCAParentMom_TurningController();	

			LUCA_MBA_Strafe.LUCAParentMom_StrafingController();
		}
	}
}