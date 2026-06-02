using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.Mom.movementbasedanimations
{
	public class TsareenaParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private TParentMom_Jumping TsareenaParentMom_MBA_Jumping;
		
		private TParentMom_Running TsareenaParentMom_MBA_Running;


		private TParentMom_Turning TsareenaParentMom_MBA_Turning;

		private TParentMom_Strafing TsareenaParentMom_MBA_Strafe;

		public void TParentMom_MovementAnimatorController()
		{
			TsareenaParentMom_MBA_Running.TParentMom_RunningController();

			TsareenaParentMom_MBA_Jumping.TParentMom_JumpingController();

			TsareenaParentMom_MBA_Turning.TParentMom_TurningController();	

			TsareenaParentMom_MBA_Strafe.TParentMom_StrafingController();
		}
	}
}