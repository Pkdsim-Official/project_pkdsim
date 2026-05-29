using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.Mom.idlebaseanimation.IdleStanding
{
	public class LUCAIdleStanding : MonoBehaviour 
	{
		public Animator Lucario_Animator;
		public void LUCAIdleStandingController()
		{
			// Assign the idle animation clip
			Lucario_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Lucario_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}