using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Garchomp.idlebaseanimation.IdleStanding
{
	public class GARC_IdleStanding : MonoBehaviour 
	{
		public Animator GarchompParentDad_Animator;
		public void GARC_IdleStandingController()
		{
			// Assign the idle animation clip
			GarchompParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GarchompParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}