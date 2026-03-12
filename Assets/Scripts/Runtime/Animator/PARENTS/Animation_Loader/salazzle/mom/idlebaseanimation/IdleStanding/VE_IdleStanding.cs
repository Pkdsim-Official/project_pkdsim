using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Salazzle.Mom.idlebaseanimation.IdleStanding
{
	public class SParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator SalazzleParentMom_Animator;
		public void SParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			SalazzleParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			SalazzleParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}