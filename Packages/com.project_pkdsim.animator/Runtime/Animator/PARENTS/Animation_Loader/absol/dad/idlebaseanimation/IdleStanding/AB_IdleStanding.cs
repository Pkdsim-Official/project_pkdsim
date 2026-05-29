using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Absol.Dad.idlebaseanimation.IdleStanding
{
	public class ABIdleStanding : MonoBehaviour 
	{
		public Animator AbsolParent_Animator;
		public void ABIdleStandingController()
		{
			// Assign the idle animation clip
			AbsolParent_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			AbsolParent_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}