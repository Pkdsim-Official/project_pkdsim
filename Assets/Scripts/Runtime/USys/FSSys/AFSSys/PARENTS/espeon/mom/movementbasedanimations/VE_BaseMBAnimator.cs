using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations.Jumping;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations.Running;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations.Strafing;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations
{
	public class EspeonParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private ESParentMom_Jumping ES_MBA_Jumping;
		
		private ESParentMom_Running ES_MBA_Running;


		private ESParentMom_Turning ES_MBA_Turning;

		private ESParentMom_Strafing ES_MBA_Strafe;

		public void ESParentMom_MovementAnimatorController()
		{
			ES_MBA_Running.ESParentMom_RunningController();

			ES_MBA_Jumping.ESParentMom_JumpingController();

			ES_MBA_Turning.ESParentMom_TurningController();	

			ES_MBA_Strafe.ESParentMom_StrafingController();
		}
	}
}