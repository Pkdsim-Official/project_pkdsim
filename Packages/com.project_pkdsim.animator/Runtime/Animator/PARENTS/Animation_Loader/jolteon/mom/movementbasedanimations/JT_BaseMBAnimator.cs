using project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.movementbasedanimations.Turning;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.movementbasedanimations.Running;
using UnityEngine;


namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Mom.movementbasedanimations
{
	public class JolteonParentMom_MovementAnimatorController : MonoBehaviour 
	{
		private JTParentMom_Jumping JTParentMom_MBA_Jumping;
		
		private JTParentMom_Running JTParentMom_MBA_Running;

		private JTParentMom_Turning JTParentMom_MBA_Turning;

		private JTParentMom_Strafing JTParentMom_MBA_Strafe;

		public void JTParentMom_MovementAnimatorController()
		{
			JTParentMom_MBA_Running.JTParentMom_RunningController();

			JTParentMom_MBA_Jumping.JTParentMom_JumpingController();

			JTParentMom_MBA_Turning.JTParentMom_TurningController();	

			JTParentMom_MBA_Strafe.JTParentMom_StrafingController();
		}
	}
}