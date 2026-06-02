using project_pkdsim.ANIMATOR.Parents.Tsareena.Dad.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Dad.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Dad.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Dad.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.Dad.movementbasedanimations
{
	public class TsareenaParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private TParentDad_Jumping TsareenaParentDad_MBA_Jumping;
		
		private TParentDad_Running TsareenaParentDad_MBA_Running;


		private TParentDad_Turning TsareenaParentDad_MBA_Turning;

		private TParentDad_Strafing TsareenaParentDad_MBA_Strafe;

		public void TParentDad_MovementAnimatorController()
		{
			TsareenaParentDad_MBA_Running.TParentDad_RunningController();

			TsareenaParentDad_MBA_Jumping.TParentDad_JumpingController();

			TsareenaParentDad_MBA_Turning.TParentDad_TurningController();	

			TsareenaParentDad_MBA_Strafe.TParentDad_StrafingController();
		}
	}
}