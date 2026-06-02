using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Mom.idlebaseanimation.IdleStanding
{
	public class GARCParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator Garchomp_Animator;
		public void GARCParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			Garchomp_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Garchomp_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}