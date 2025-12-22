using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Salazzle.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class SParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator SalazzleParentMom_Animator;
		public void SParentMom_WalkingToStandingController()
		{
			SalazzleParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			SalazzleParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}