using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Salazzle.idlebaseanimation.IdleStanding
{
	public class SA_IdleStanding : MonoBehaviour 
	{
		public Animator SalazzleParentDad_Animator;
		public void SA_IdleStandingController()
		{
			// Assign the idle animation clip
			SalazzleParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			SalazzleParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}