using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Dad.idlebaseanimation.IdleStanding
{
	public class GLParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator GlaceonParentDad_Animator;
		public void GLParentDad_IdleStandingController()
		{
			GlaceonParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GlaceonParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}