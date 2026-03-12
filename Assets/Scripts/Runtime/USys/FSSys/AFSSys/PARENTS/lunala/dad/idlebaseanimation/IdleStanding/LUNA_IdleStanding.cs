using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.idlebaseanimation.IdleStanding
{
	public class LUNAIdleStanding : MonoBehaviour 
	{
		public Animator LunalaParentDad_Animator;
		public void LUNAIdleStandingController()
		{
			// Assign the idle animation clip
			LunalaParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LunalaParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}