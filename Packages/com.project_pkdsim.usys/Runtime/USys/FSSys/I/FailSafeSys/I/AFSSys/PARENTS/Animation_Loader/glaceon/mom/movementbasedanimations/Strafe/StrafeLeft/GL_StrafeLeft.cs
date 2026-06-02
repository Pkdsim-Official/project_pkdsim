using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.movementbasedanimations.Strafing.StrafeLeft
{
	public class GLParentMom_StrafeLeft : MonoBehaviour 
	{
		private Animator GlaceonParentMom_Animator;
		private void GLParentMom_StrafeLeftController()
		{
			GlaceonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GlaceonParentMom_Animator.Play("Strafe_Left");         // Start in the Idle animation state
		}
	}
}