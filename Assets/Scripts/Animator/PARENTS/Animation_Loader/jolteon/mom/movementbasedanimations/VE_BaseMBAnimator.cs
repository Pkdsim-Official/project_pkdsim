using project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.movementbasedanimations.Running;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.movementbasedanimations
{
	public class JolteonParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private JTParentMom_Jumping JT_MBA_Jumping;
		
		private JTParentMom_Running JT_MBA_Running;

		private JTParentMom_Turning JT_MBA_Turning;

		private JTParentMom_Strafing JT_MBA_Strafe;

		public void JTParentMom_MovementAnimatorController()
		{
			JT_MBA_Running.JTParentMom_RunningController();

			JT_MBA_Jumping.JTParentMom_JumpingController();

			JT_MBA_Turning.JTParentMom_TurningController();	

			JT_MBA_Strafe.JTParentMom_StrafingController();
		}
	}
}