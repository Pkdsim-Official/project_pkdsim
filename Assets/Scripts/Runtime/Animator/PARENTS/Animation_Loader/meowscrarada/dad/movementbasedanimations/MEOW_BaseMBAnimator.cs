using Project_Pkdsim.ANIMATOR.Parents.Meowscarada.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Parents.Meowscarada.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Parents.Meowscarada.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Parents.Meowscarada.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Meowscarada.movementbasedanimations
{
	public class MeowscaradaParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private MEOWParent_Jumping Meowscarada_MBA_Jumping;
		
		private MEOWParent_Running Meowscarada_MBA_Running;


		private MEOWParent_Turning Meowscarada_MBA_Turning;

		private MEOWParent_Strafing Meowscarada_MBA_Strafe;

		public void MEOWMovementAnimatorController()
		{
			Meowscarada_MBA_Running.MEOWParent_RunningController();

			Meowscarada_MBA_Jumping.MEOWParent_JumpingController();

			Meowscarada_MBA_Turning.MEOWParent_TurningController();	

			Meowscarada_MBA_Strafe.MEOWParent_StrafingController();
		}
	}
}