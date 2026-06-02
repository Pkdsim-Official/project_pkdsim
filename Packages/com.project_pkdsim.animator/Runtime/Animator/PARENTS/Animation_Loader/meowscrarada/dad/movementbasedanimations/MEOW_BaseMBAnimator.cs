using project_pkdsim.ANIMATOR.Parents.Meowscarada.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Meowscarada.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Meowscarada.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Meowscarada.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Meowscarada.movementbasedanimations
{
	public class MeowscaradaParent_MovementAnimatorController : MonoBehaviour 
	{
		private MEOW_Parent_Jumping Meowscarada_MBA_Jumping;
		
		private MEOW_Parent_Running Meowscarada_MBA_Running;


		private MEOW_Parent_Turning Meowscarada_MBA_Turning;

		private MEOW_Parent_Strafing Meowscarada_MBA_Strafe;

		public void MEOW_MovementAnimatorController()
		{
			Meowscarada_MBA_Running.MEOW_Parent_RunningController();

			Meowscarada_MBA_Jumping.MEOW_Parent_JumpingController();

			Meowscarada_MBA_Turning.MEOW_Parent_TurningController();	

			Meowscarada_MBA_Strafe.MEOW_Parent_StrafingController();
		}
	}
}