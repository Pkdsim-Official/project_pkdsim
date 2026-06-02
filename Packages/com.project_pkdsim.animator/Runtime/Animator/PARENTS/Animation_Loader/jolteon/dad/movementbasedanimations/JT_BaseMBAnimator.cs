using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.movementbasedanimations.Turning;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.movementbasedanimations.Strafing;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.movementbasedanimations.Jumping;
using project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.movementbasedanimations.Running;
using UnityEngine;


namespace project_pkdsim.ANIMATOR.Parents.Jolteon.Dad.movementbasedanimations
{
	public class JolteonParentDad_MovementAnimatorController : MonoBehaviour 
	{
		private JTParentDad_Jumping JTParentDad_MBA_Jumping;
		
		private JTParentDad_Running JTParentDad_MBA_Running;

		private JTParentDad_Turning JTParentDad_MBA_Turning;

		private JTParentDad_Strafing JTParentDad_MBA_Strafe;

		public void JTParentDad_MovementAnimatorController()
		{
			JTParentDad_MBA_Running.JTParentDad_RunningController();

			JTParentDad_MBA_Jumping.JTParentDad_JumpingController();

			JTParentDad_MBA_Turning.JTParentDad_TurningController();	

			JTParentDad_MBA_Strafe.JTParentDad_StrafingController();
		}
	}
}