using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Dad.idlebaseanimation.IdleStanding
{
	public class LUNAParentDad_IdleStanding : MonoBehaviour 
	{
		public Animator LunalaParentDad_Animator;
		public void LUNAParentDad_IdleStandingController()
		{
			// Assign the idle animation clip
			LunalaParentDad_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LunalaParentDad_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}