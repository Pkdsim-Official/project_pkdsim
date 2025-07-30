using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.idlebaseanimation.IdleSitting
{
	public class GLParentMom_IdleSitting : MonoBehaviour 
	{
		private Animator GlaceonParentMom_Animator;
		public void GLParentMom_IdleSittingController()
		{
			GlaceonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GlaceonParentMom_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}