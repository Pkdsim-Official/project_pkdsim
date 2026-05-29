using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations.Turning;
using UnityEngine;


namespace project_pkdsim.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations
{
	public class EspeonParent_AnimatorMovementController : MonoBehaviour 
	{
		private ESParent_Jumping ES_MBA_Jumping;
		
		private ESParent_Running ES_MBA_Running;

		private ESParent_Turning ES_MBA_Turning;

		private ESParent_Strafing ES_MBA_Strafe;

		private void ES_Base_IdleAnimatorController()
		{
			ES_MBA_Running.ESParent_RunningController();

			ES_MBA_Jumping.ESParent_JumpingController();

			ES_MBA_Turning.ESParent_TurningController();	

			ES_MBA_Strafe.ESParent_StrafingController();
		}
	}
}