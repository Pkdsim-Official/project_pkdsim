using project_pkdsim.ANIMATOR.Parents.Lucario.Dad.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Lucario.Dad.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Lucario.Dad.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Lucario.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.Dad.movementbasedanimations
{
	public class LucarioParentDad_MovementAnimatorController : MonoBehaviour
	{
		private LUCAParentDad_Jumping Lucario_MBA_Jumping;

		private LUCAParentDad_Running Lucario_MBA_Running;

		private LUCAParentDad_Turning Lucario_MBA_Turning;

		private LUCAParentDad_Strafing Lucario_MBA_Strafe;

		public void LUCAParentDad_MovementAnimatorController()
		{
			Lucario_MBA_Running.LUCAParentDad_RunningController();

			Lucario_MBA_Jumping.LUCAParentDad_JumpingController();

			Lucario_MBA_Turning.LUCAParentDad_TurningController();

			Lucario_MBA_Strafe.LUCAParentDad_StrafingController();
		}
	}
}