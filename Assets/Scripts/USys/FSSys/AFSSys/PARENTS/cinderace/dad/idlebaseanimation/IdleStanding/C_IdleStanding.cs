using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.Dad.idlebaseanimation.IdleStanding
{
	public class CParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator CinderaceParentDad_Animator;
		public void CParentDad_IdleStandingController()
		{
			// Assign the idle animation clip
			CinderaceParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			CinderaceParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}