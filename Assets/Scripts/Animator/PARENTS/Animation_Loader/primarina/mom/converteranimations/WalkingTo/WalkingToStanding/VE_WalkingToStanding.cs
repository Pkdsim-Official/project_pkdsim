using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Primarina.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class PRParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator PrimarinaParentMom_Animator;
		public void PRParentMom_WalkingToStandingController()
		{
			PrimarinaParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			PrimarinaParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}