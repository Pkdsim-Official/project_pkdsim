using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Beedrill.Dad.idlebaseanimation.IdleStanding
{
	public class BEParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator BeedrillParentDad_Animator;
		public void BEParentDad_IdleStandingController()
		{
			// Assign the idle animation clip
			BeedrillParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BeedrillParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}