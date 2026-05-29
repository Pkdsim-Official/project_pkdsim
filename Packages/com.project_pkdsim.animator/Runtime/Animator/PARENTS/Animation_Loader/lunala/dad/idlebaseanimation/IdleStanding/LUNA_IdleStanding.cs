using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lunala.Dad.idlebaseanimation.IdleStanding
{
	public class LUNAIdleStanding : MonoBehaviour 
	{
		public Animator Lunala_Animator;
		public void LUNAIdleStandingController()
		{
			// Assign the idle animation clip
			Lunala_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Lunala_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}