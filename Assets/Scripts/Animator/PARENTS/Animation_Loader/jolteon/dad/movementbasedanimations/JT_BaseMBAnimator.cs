using project_pkdsim.ANIMATOR.Parents.Jolteon.movementbasedanimations.Turning;
using project_pkdsim.ANIMATOR.Parents.Jolteon.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Jolteon.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Jolteon.movementbasedanimations.Running;
using UnityEngine;


namespace project_pkdsim.ANIMATOR.Parents.Jolteon.movementbasedanimations
{
	public class JolteonParent_AnimatorBaseMovementController : MonoBehaviour 
	{
		private JTParent_Jumping JT_MBA_Jumping;
		
		private JTParent_Running JT_MBA_Running;

		private JTParent_Turning JT_MBA_Turning;

		private JTParent_Strafing JT_MBA_Strafe;

		public void JT_MovementAnimatorController()
		{
			JT_MBA_Running.JTParent_RunningController();

			JT_MBA_Jumping.JTParent_JumpingController();

			JT_MBA_Turning.JTParent_TurningController();	

			JT_MBA_Strafe.JTParent_StrafingController();
		}
	}
}