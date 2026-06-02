using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.idlebaseanimation.IdleStanding
{
	public class JT_IdleStanding : MonoBehaviour 
	{
		public Animator JolteonParentMom_Animator;
		public void JT_IdleStandingController()
		{
			JolteonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			JolteonParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}