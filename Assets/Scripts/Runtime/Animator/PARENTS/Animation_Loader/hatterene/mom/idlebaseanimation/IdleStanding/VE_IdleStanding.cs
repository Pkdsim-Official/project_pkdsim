using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Hatterene.Mom.idlebaseanimation.IdleStanding
{
	public class HATParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator HattereneParentMom_Animator;
		public void HATParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			HattereneParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			HattereneParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}