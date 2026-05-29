using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Strafing.StrafeRight
{
	public class GL_StrafeRight : MonoBehaviour
	{
		private Animator Glaceon_Animator;
		private void GL_StrafeRightController()
		{
			Glaceon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Glaceon_Animator.Play("Strafe_Right");  // Start in the Idle animation state
		}
	}
}