using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Delphox.idlebaseanimation.IdleStanding
{
	public class DLIdleStanding : MonoBehaviour 
	{
		public Animator DelphoxParentDad_Animator;
		public void DLIdleStandingController()
		{
			// Assign the idle animation clip
			DelphoxParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			DelphoxParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}