using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Meowscarada.idlebaseanimation.IdleStanding
{
	public class MEOWIdleStanding : MonoBehaviour 
	{
		public Animator Meowscarada_Animator;
		public void MEOWIdleStandingController()
		{
			// Assign the idle animation clip
			Meowscarada_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Meowscarada_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}