using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Beedrill.Mom.idlebaseanimation.IdleStanding
{
	public class BEParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator BeedrillParentMom_Animator;
		public void BEParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			BeedrillParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BeedrillParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}