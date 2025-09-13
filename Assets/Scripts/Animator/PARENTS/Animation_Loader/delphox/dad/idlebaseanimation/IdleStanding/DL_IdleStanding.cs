using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Delphox.idlebaseanimation.IdleStanding
{
	public class DLIdleStanding : MonoBehaviour 
	{
		public Animator Delphox_Animator;
		public void DLIdleStandingController()
		{
			// Assign the idle animation clip
			Delphox_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Delphox_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}