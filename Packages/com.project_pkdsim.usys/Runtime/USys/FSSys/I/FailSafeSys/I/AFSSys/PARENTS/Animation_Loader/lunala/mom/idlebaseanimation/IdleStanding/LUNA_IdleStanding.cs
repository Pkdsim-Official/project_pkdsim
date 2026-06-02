using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.idlebaseanimation.IdleStanding
{
	public class LUNAParentMom_IdleStanding : MonoBehaviour 
	{
		public Animator LunalaParentMom_Animator;
		public void LUNAParentMom_IdleStandingController()
		{
			// Assign the idle animation clip
			LunalaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LunalaParentMom_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}