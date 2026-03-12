using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.idlebaseanimation.IdleSitting
{
	public class GLParentDad_IdleSitting : MonoBehaviour 
	{
		private Animator GlaceonParentDad_Animator;
		public void GLParentDad_IdleSittingController()
		{
			GlaceonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GlaceonParentDad_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}