using project_pkdsim.ANIMATOR.Parents.Hatterene.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Hatterene.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Hatterene.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Hatterene.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Hatterene.movementbasedanimations
{
	public class HattereneParent_AnimatorBaseMovementController : MonoBehaviour 
	{
		private HATParent_Jumping Hatterene_MBA_Jumping;
		
		private HATParent_Running Hatterene_MBA_Running;


		private HATParent_Turning Hatterene_MBA_Turning;

		private HATParent_Strafing Hatterene_MBA_Strafe;

		public void HATMovementAnimatorController()
		{
			Hatterene_MBA_Running.HATParent_RunningController();

			Hatterene_MBA_Jumping.HATParent_JumpingController();

			Hatterene_MBA_Turning.HATParent_TurningController();	

			Hatterene_MBA_Strafe.HATParent_StrafingController();
		}
	}
}