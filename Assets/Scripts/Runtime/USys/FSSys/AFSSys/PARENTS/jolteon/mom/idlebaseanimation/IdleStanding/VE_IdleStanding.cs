using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Mom.idlebaseanimation.IdleStanding
{
	public class JTParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator JolteonParentMom_Animator;
		public void JTParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			JolteonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			JolteonParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}