using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.idlebaseanimation.IdleStanding
{
	public class GARCParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator GarchompParentMom_Animator;
		public void GARCParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			GarchompParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			GarchompParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}