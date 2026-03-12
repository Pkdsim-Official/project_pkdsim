using Project_Pkdsim.ANIMATOR.Parents.Tsareena.Mom.movementbasedanimations.Jumping;
using Project_Pkdsim.ANIMATOR.Parents.Tsareena.Mom.movementbasedanimations.Running;
using Project_Pkdsim.ANIMATOR.Parents.Tsareena.Mom.movementbasedanimations.Strafing;
using Project_Pkdsim.ANIMATOR.Parents.Tsareena.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Tsareena.Mom.movementbasedanimations
{
	public class TsareenaParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private TParentMom_Jumping T_MBA_Jumping;
		
		private TParentMom_Running T_MBA_Running;


		private TParentMom_Turning T_MBA_Turning;

		private TParentMom_Strafing T_MBA_Strafe;

		public void TParentMom_MovementAnimatorController()
		{
			T_MBA_Running.TParentMom_RunningController();

			T_MBA_Jumping.TParentMom_JumpingController();

			T_MBA_Turning.TParentMom_TurningController();	

			T_MBA_Strafe.TParentMom_StrafingController();
		}
	}
}