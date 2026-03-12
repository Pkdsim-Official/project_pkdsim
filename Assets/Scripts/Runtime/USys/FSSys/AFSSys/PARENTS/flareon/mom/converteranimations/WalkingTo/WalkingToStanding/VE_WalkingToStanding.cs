using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Flareon.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class FLParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator FlareonParentMom_Animator;
		public void FLParentMom_WalkingToStandingController()
		{
			FlareonParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FlareonParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}