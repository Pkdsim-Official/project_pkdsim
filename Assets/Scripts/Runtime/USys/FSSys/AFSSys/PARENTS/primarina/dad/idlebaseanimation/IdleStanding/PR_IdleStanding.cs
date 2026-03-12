using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Primarina.idlebaseanimation.IdleStanding
{
	public class PRIdleStanding : MonoBehaviour 
	{
		public Animator PrimarinaParentDad_Animator;
		public void PRIdleStandingController()
		{
			// Assign the idle animation clip
			PrimarinaParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			PrimarinaParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}