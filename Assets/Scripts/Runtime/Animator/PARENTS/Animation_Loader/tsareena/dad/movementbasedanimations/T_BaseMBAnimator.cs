using Project_Pkdsim.ANIMATOR.Parents.Tsareena.Dad.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Parents.Tsareena.Dad.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Parents.Tsareena.Dad.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Parents.Tsareena.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Tsareena.Dad.movementbasedanimations
{
	public class TsareenaParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private TParentDad_Jumping Tsareena_MBA_Jumping;
		
		private TParentDad_Running Tsareena_MBA_Running;

		private TParentDad_Turning Tsareena_MBA_Turning;

		private TParentDad_Strafing Tsareena_MBA_Strafe;

		public void TParentDad_MovementAnimatorController()
		{
			Tsareena_MBA_Running.TParentDad_RunningController();

			Tsareena_MBA_Jumping.TParentDad_JumpingController();

			Tsareena_MBA_Turning.TParentDad_TurningController();	

			Tsareena_MBA_Strafe.TParentDad_StrafingController();
		}
	}
}