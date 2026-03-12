using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.converteranimations.IdleTo.IdleToRun
{
	public class GLParentMom_IdleToRun : MonoBehaviour 
	{
		private Animator GlaceonParentMom_Animator;
		public void GLParentMom_IdleToRunController()
		{
			GlaceonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GlaceonParentMom_Animator.Play("Idle_Sitting");  // Start in the Idle animation state
		}
	}
}