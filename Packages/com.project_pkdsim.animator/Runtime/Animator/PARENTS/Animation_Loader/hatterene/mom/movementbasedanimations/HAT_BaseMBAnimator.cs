using project_pkdsim.ANIMATOR.Parents.Hatterene.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Hatterene.Mom.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Hatterene.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Hatterene.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Hatterene.Mom.movementbasedanimations
{
	public class HattereneParent_MovementAnimatorController : MonoBehaviour 
	{
		private HAT_Parent_Jumping Hatterene_MBA_Jumping;
		
		private HAT_Parent_Running Hatterene_MBA_Running;


		private HAT_Parent_Turning Hatterene_MBA_Turning;

		private HAT_Parent_Strafing Hatterene_MBA_Strafe;

		public void HAT_MovementAnimatorController()
		{
			Hatterene_MBA_Running.HAT_Parent_RunningController();

			Hatterene_MBA_Jumping.HAT_Parent_JumpingController();

			Hatterene_MBA_Turning.HAT_Parent_TurningController();	

			Hatterene_MBA_Strafe.HAT_Parent_StrafingController();
		}
	}
}