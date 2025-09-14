using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Zoroark.Mom.idlebaseanimation.IdleStanding
{
	public class ZParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator ZoroarkParentMom_Animator;
		public void ZParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			ZoroarkParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			ZoroarkParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}