using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Dad.idlebaseanimation.IdleStanding
{
	public class ABIdleStanding : MonoBehaviour 
	{
		public Animator AbsolParentDad_Animator;
		public void ABIdleStandingController()
		{
			// Assign the idle animation clip
			AbsolParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			AbsolParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}