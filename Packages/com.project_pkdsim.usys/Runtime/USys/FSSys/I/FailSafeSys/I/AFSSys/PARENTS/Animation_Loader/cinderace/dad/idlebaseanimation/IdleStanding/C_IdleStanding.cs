using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Cinderace.idlebaseanimation.IdleStanding
{
	public class C_IdleStanding : MonoBehaviour 
	{
		public Animator CinderaceParentDad_Animator;
		public void C_IdleStandingController()
		{
			// Assign the idle animation clip
			CinderaceParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			CinderaceParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}