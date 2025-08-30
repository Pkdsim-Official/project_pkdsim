using project_pkdsim.Models.ANIMATOR.NPC.Hatterene.movementbasedanimations.Jumping;
using project_pkdsim.Models.ANIMATOR.NPC.Hatterene.movementbasedanimations.Running;
using project_pkdsim.Models.ANIMATOR.NPC.Hatterene.movementbasedanimations.Strafe;
using project_pkdsim.Models.ANIMATOR.NPC.Hatterene.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Models.ANIMATOR.NPC.Hatterene.movementbasedanimations
{
	public class Hatterene_AnimatorBaseMovementController : MonoBehaviour 
	{
		private HAT_Jumping Hatterene_MBA_Jumping;
		
		private HAT_Running Hatterene_MBA_Running;


		private HAT_Turning Hatterene_MBA_Turning;

		private HAT_Strafing Hatterene_MBA_Strafe;

		public void HATMovementAnimatorController()
		{
			Hatterene_MBA_Running.HAT_RunningController();

			Hatterene_MBA_Jumping.HAT_JumpingController();

			Hatterene_MBA_Turning.HAT_TurningController();	

			Hatterene_MBA_Strafe.HAT_StrafingController();
		}
	}
}