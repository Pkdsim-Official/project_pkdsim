using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Blaziken.idlebaseanimation.IdleStanding
{
	public class BL_IdleStanding : MonoBehaviour 
	{
		public Animator BlazikenParentDad_Animator;
		public void BL_IdleStandingController()
		{
			// Assign the idle animation clip
			BlazikenParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			BlazikenParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}