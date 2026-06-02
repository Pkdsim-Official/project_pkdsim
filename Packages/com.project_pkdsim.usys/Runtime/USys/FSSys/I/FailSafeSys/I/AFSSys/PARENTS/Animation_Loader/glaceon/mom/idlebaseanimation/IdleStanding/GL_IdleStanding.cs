using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Glaceon.Mom.idlebaseanimation.IdleStanding
{
	public class GLParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator GlaceonParentMom_Animator;
		public void GLParentMom_IdleStandingController()
		{
			GlaceonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GlaceonParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}