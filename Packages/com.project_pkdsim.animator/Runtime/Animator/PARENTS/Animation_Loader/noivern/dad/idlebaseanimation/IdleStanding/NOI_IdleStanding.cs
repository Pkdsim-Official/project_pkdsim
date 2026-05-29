using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.Dad.idlebaseanimation.IdleStanding
{
	public class NOIIdleStanding : MonoBehaviour 
	{
		public Animator NoivernParentDad_Animator;
		public void NOIIdleStandingController()
		{
			// Assign the idle animation clip
			NoivernParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			NoivernParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}