using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Strafing.StrafeRight
{
	public class GLParentMom_StrafeRight : MonoBehaviour
	{
		private Animator GlaceonParentMom_Animator;
		private void GLParentMom_StrafeRightController()
		{
			GlaceonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GlaceonParentMom_Animator.Play("Strafe_Right");  // Start in the Idle animation state
		}
	}
}