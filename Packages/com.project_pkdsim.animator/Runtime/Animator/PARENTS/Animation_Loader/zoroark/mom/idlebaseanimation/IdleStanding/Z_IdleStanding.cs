using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Zoroark.Mom.idlebaseanimation.IdleStanding
{
	public class ZParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator Zoroark_Animator;
		public void ZParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			Zoroark_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Zoroark_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}