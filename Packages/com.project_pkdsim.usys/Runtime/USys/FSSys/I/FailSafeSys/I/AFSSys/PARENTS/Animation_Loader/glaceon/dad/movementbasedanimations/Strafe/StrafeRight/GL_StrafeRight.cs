using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Strafing.StrafeRight
{
	public class GLParentDad_StrafeRight : MonoBehaviour
	{
		private Animator GlaceonParentDad_Animator;
		private void GLParentDad_StrafeRightController()
		{
			GlaceonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GlaceonParentDad_Animator.Play("Strafe_Right");  // Start in the Idle animation state
		}
	}
}