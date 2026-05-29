using project_pkdsim.ANIMATOR.Parents.Lucario.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Lucario.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Lucario.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Lucario.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.movementbasedanimations
{
	public class LucarioParent_AnimatorMovementController : MonoBehaviour 
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