using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Garchomp.Dad.idlebaseanimation.IdleStanding
{
	public class GARCParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator Garchomp_Animator;
		public void GARCParentDad_IdleStandingController()
		{
			// Assign the idle animation clip
			Garchomp_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Garchomp_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}