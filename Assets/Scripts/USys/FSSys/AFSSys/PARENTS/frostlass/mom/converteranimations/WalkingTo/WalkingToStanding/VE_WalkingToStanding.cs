using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Frostlass.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class FRParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator FrostlassParentMom_Animator;
		public void FRParentMom_WalkingToStandingController()
		{
			FrostlassParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			FrostlassParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}