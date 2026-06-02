using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Mom.idlebaseanimation.IdleStanding
{
	public class SYLParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator Sylveon_Animator;
		public void SYLParentMom_IdleStandingController()
		{
			Sylveon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Sylveon_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}