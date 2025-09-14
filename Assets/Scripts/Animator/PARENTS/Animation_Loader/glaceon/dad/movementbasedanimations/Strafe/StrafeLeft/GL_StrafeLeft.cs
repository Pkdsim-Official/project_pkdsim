using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Glaceon.Dad.movementbasedanimations.Strafing.StrafeLeft
{
	public class GLParentDad_StrafeLeft : MonoBehaviour 
	{
		private Animator GlaceonParentDad_Animator;
		public void GLParentDad_StrafeLeftController()
		{
			GlaceonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GlaceonParentDad_Animator.Play("Strafe_Left");         // Start in the Idle animation state
		}
	}
}