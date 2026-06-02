using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Sylveon.Dad.idlebaseanimation.IdleStanding
{
	public class SYLParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator Sylveon_Animator;
		public void SYLParentDad_IdleStandingController()
		{
			Sylveon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Sylveon_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}