using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.idlebaseanimation.IdleStanding
{
	public class FRIdleStanding : MonoBehaviour 
	{
		public Animator FrostlassParentDad_Animator;
		public void FRIdleStandingController()
		{
			// Assign the idle animation clip
			FrostlassParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FrostlassParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}