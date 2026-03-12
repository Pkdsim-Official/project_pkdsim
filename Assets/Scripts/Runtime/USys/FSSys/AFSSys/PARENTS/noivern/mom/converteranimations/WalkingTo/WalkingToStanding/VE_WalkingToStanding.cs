using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.converteranimations.WalkingTo.WalkingToStanding
{
	public class NOIParentMom_WalkingToStanding : MonoBehaviour 
	{
		private Animator NoivernParentMom_Animator;
		public void NOIParentMom_WalkingToStandingController()
		{
			NoivernParentMom_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			NoivernParentMom_Animator.Play("WalkingTo_Standing");         // Start in the WalkingToStandingCon state
		}
	}
}