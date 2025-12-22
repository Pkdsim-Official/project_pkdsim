using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lunala.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class LUNAParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator LunalaParentMom_Animator;
		public void LUNAParentMom_WalkingToStandingController()
		{
			LunalaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			LunalaParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}