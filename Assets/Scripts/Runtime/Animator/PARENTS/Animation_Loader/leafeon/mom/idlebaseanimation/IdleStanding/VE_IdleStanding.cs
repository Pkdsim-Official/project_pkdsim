using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Leafeon.Mom.idlebaseanimation.IdleStanding
{
	public class LEParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator LeafeonParentMom_Animator;
		public void LEParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			LeafeonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LeafeonParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}