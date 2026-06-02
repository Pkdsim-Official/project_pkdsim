using project_pkdsim.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations
{
	public class LucarioParent_MovementAnimatorController : MonoBehaviour 
	{
		private LUCAParent_Jumping Lucario_MBA_Jumping;
		
		private LUCAParent_Running Lucario_MBA_Running;


		private LUCAParent_Turning Lucario_MBA_Turning;

		private LUCAParent_Strafing Lucario_MBA_Strafe;

		public void LUCAMovementAnimatorController()
		{
			Lucario_MBA_Running.LUCAParent_RunningController();

			Lucario_MBA_Jumping.LUCAParent_JumpingController();

			Lucario_MBA_Turning.LUCAParent_TurningController();	

			Lucario_MBA_Strafe.LUCAParent_StrafingController();
		}
	}
}