using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.Mom.idlebaseanimation.IdleStanding
{
	public class PRParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator PrimarinaParentMom_Animator;
		public void PRParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			PrimarinaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			PrimarinaParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}