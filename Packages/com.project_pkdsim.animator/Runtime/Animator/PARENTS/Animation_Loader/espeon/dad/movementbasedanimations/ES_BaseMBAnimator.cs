using project_pkdsim.ANIMATOR.Parents.Espeon.Dad.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Espeon.Dad.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Espeon.Dad.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Espeon.Dad.movementbasedanimations.Turning;
using UnityEngine;


namespace project_pkdsim.ANIMATOR.Parents.Espeon.Dad.movementbasedanimations
{
	public class EspeonParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private ESParentDad_Jumping ES_MBA_Jumping;
		
		private ESParentDad_Running ES_MBA_Running;

		private ESParentDad_Turning ES_MBA_Turning;

		private ESParentDad_Strafing ES_MBA_Strafe;

		public void ESParentDad_MovementAnimatorController()
		{
			ES_MBA_Running.ESParentDad_RunningController();

			ES_MBA_Jumping.ESParentDad_JumpingController();

			ES_MBA_Turning.ESParentDad_TurningController();	

			ES_MBA_Strafe.ESParentDad_StrafingController();
		}
	}
}